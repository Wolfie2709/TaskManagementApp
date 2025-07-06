using System;
using System.Windows.Forms;
using AppTask = TaskManagementApp.Models.Task;
using TaskManagementApp.Models;

namespace TaskManagementApp
{
    public partial class MainForm : Form
    {
        private User currentUser;
        private TaskService taskService = new TaskService();
        private TaskList currentTaskList;

        public MainForm(User user)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;

            var borderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm();
            borderlessForm.ContainerControl = this;

            currentUser = user;
            currentTaskList = null;
            lvTaskSummary.Items.Clear();

            // Bind calendar and buttons if not already bound in designer
            calendar.DateChanged += calendar_DateChanged;
            btnEditTask.Click += btnEditTask_Click;
            btnSearch.Click += btnSearch_Click;
            btnFilterPriority.Click += btnFilterPriority_Click;
        }

        private void lvTaskSummary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTaskSummary.SelectedItems.Count == 0) return;

            var selectedItem = lvTaskSummary.SelectedItems[0];
            var task = selectedItem.Tag as AppTask;

            if (task == null)
            {
                MessageBox.Show("Could not retrieve task data.");
                return;
            }

            lvTaskDetails.Items.Clear();
            lvTaskDetails.Items.Add(new ListViewItem(new[] { "Title", task.Title }));
            lvTaskDetails.Items.Add(new ListViewItem(new[] { "Description", task.Description }));
            lvTaskDetails.Items.Add(new ListViewItem(new[] { "Status", task.Status }));
            lvTaskDetails.Items.Add(new ListViewItem(new[] { "Due Date", task.DueDate?.ToString("g") ?? "N/A" }));
            lvTaskDetails.Items.Add(new ListViewItem(new[] { "Priority", task.Priority }));
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            AddTask form = new AddTask(currentUser, currentTaskList);
            if (form.ShowDialog() == DialogResult.OK && currentTaskList != null)
            {
                LoadTasksByTaskList(currentTaskList.TaskListID);
            }
        }

        private void btnTaskLists_Click(object sender, EventArgs e)
        {
            TaskListForm form = new TaskListForm(currentUser);
            if (form.ShowDialog() == DialogResult.OK && form.SelectedTaskList != null)
            {
                currentTaskList = form.SelectedTaskList;
                LoadTasksByTaskList(currentTaskList.TaskListID);
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (lvTaskSummary.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a task to delete.");
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this task?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes) return;

            var selectedItem = lvTaskSummary.SelectedItems[0];
            var task = selectedItem.Tag as AppTask;
            if (task == null) return;

            bool success = taskService.DeleteTask(task.TaskID);

            if (success)
            {
                MessageBox.Show("Task deleted.");
                LoadTasksByTaskList(currentTaskList.TaskListID);
                lvTaskDetails.Items.Clear();
            }
            else
            {
                MessageBox.Show("Failed to delete task.");
            }
        }


        private void LoadTasksByTaskList(int taskListId)
        {
            lvTaskSummary.Items.Clear();
            var tasks = taskService.GetTasksByUserAndTaskList(currentUser.UserID, taskListId);
            foreach (AppTask task in tasks)
            {
                var item = new ListViewItem(task.TaskID.ToString());
                item.SubItems.Add(task.Title);
                item.Tag = task;
                lvTaskSummary.Items.Add(item);
            }
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (currentTaskList == null) return;

            DateTime selectedDate = e.Start.Date;
            var tasks = taskService.GetTasksByUserAndTaskList(currentUser.UserID, currentTaskList.TaskListID);
            var filtered = tasks.FindAll(t => t.DueDate.HasValue && t.DueDate.Value.Date == selectedDate);

            lvTaskSummary.Items.Clear();
            foreach (AppTask task in filtered)
            {
                var item = new ListViewItem(task.TaskID.ToString());
                item.SubItems.Add(task.Title);
                item.Tag = task;
                lvTaskSummary.Items.Add(item);
            }

            lvTaskDetails.Items.Clear();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginForm().Show();
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (lvTaskSummary.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a task to edit.");
                return;
            }

            var selectedItem = lvTaskSummary.SelectedItems[0];
            var task = selectedItem.Tag as AppTask;
            if (task == null) return;

            var form = new AddTask(currentUser, currentTaskList, task);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadTasksByTaskList(currentTaskList.TaskListID);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (currentTaskList == null) return;

            string keyword = txtSearch.Text.Trim().ToLower();
            var tasks = taskService.GetTasksByUserAndTaskList(currentUser.UserID, currentTaskList.TaskListID);
            var filtered = tasks.FindAll(t =>
                (!string.IsNullOrEmpty(t.Title) && t.Title.ToLower().Contains(keyword)) ||
                (!string.IsNullOrEmpty(t.Description) && t.Description.ToLower().Contains(keyword))
            );

            lvTaskSummary.Items.Clear();
            foreach (AppTask task in filtered)
            {
                var item = new ListViewItem(task.TaskID.ToString());
                item.SubItems.Add(task.Title);
                item.Tag = task;
                lvTaskSummary.Items.Add(item);
            }

            lvTaskDetails.Items.Clear();
        }

        private void btnFilterPriority_Click(object sender, EventArgs e)
        {
            if (currentTaskList == null) return;

            string selectedPriority = cbPriorityFilter.SelectedItem?.ToString();
            var tasks = taskService.GetTasksByUserAndTaskList(currentUser.UserID, currentTaskList.TaskListID);

            if (selectedPriority != "All")
            {
                tasks = tasks.FindAll(t => t.Priority.Equals(selectedPriority, StringComparison.OrdinalIgnoreCase));
            }

            lvTaskSummary.Items.Clear();
            foreach (AppTask task in tasks)
            {
                var item = new ListViewItem(task.TaskID.ToString());
                item.SubItems.Add(task.Title);
                item.Tag = task;
                lvTaskSummary.Items.Add(item);
            }

            lvTaskDetails.Items.Clear();
        }

    }

}

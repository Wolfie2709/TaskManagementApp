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

            this.FormBorderStyle = FormBorderStyle.None; // Bỏ viền gốc
            this.StartPosition = FormStartPosition.CenterScreen;

            var borderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm();
            borderlessForm.ContainerControl = this;

            currentUser = user;
            currentTaskList = null; // No list selected yet
            lvTaskSummary.Items.Clear(); // Clear on startup

        }

        private void lvTaskSummary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTaskSummary.SelectedItems.Count == 0) return;

            var selectedItem = lvTaskSummary.SelectedItems[0];
            var task = selectedItem.Tag as AppTask; // Fix: Use AppTask instead of Task

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
            AddTask form = new AddTask(currentUser, currentTaskList); // ✅ pass list
            if (form.ShowDialog() == DialogResult.OK && currentTaskList != null)
            {
                LoadTasksByTaskList(currentTaskList.TaskListID); // refresh tasks in the same list
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

            lvTaskDetails.Items.Clear(); // clear details panel
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginForm().Show();
        }
    }
}
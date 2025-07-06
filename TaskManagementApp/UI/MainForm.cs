using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TaskManagementApp.Models;
using AppTask = TaskManagementApp.Models.Task;

namespace TaskManagementApp
{
    public partial class MainForm : Form
    {
        private User currentUser;
        private TaskList currentTaskList;
        private TaskService taskService = new TaskService();
        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessForm;

        public MainForm(User user)
        {
            InitializeComponent();

            borderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this);

            this.StartPosition = FormStartPosition.CenterScreen;
            currentUser = user;
            currentTaskList = null;


            // Bind events
            btnAddTask.Click += btnAddTask_Click;
            btnTaskLists.Click += btnTaskLists_Click;
            btnEditTask.Click += btnEditTask_Click;
            btnDeleteTask.Click += btnDeleteTask_Click;
            btnSearch.Click += btnSearch_Click;
            btnFilterPriority.Click += btnFilterPriority_Click;
            calendar.DateChanged += calendar_DateChanged;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            var form = new AddTask(currentUser, currentTaskList);
            if (form.ShowDialog() == DialogResult.OK && currentTaskList != null)
                LoadTasksByTaskList(currentTaskList.TaskListID);
        }

        private void btnTaskLists_Click(object sender, EventArgs e)
        {
            var form = new TaskListForm(currentUser);
            if (form.ShowDialog() == DialogResult.OK && form.SelectedTaskList != null)
            {
                currentTaskList = form.SelectedTaskList;
                LoadTasksByTaskList(currentTaskList.TaskListID);
            }
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (lvTaskSummary.SelectedItems.Count == 0) return;
            var task = lvTaskSummary.SelectedItems[0].Tag as AppTask;
            if (task == null) return;

            var form = new AddTask(currentUser, currentTaskList, task);
            if (form.ShowDialog() == DialogResult.OK)
                LoadTasksByTaskList(currentTaskList.TaskListID);
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (lvTaskSummary.SelectedItems.Count == 0) return;
            var task = lvTaskSummary.SelectedItems[0].Tag as AppTask;
            if (task == null) return;

            if (MessageBox.Show("Delete this task?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (taskService.DeleteTask(task.TaskID))
                {
                    LoadTasksByTaskList(currentTaskList.TaskListID);
                    lvTaskDetails.Items.Clear();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (currentTaskList == null) return;
            string keyword = txtSearch.Text.ToLower();
            var tasks = taskService.GetTasksByUserAndTaskList(currentUser.UserID, currentTaskList.TaskListID);
            var filtered = tasks.Where(t =>
                (!string.IsNullOrEmpty(t.Title) && t.Title.ToLower().Contains(keyword)) ||
                (!string.IsNullOrEmpty(t.Description) && t.Description.ToLower().Contains(keyword))
            ).ToList();

            DisplayTasks(filtered);
        }

        private void btnFilterPriority_Click(object sender, EventArgs e)
        {
            if (currentTaskList == null) return;
            string selected = cbPriorityFilter.SelectedItem?.ToString();
            var tasks = taskService.GetTasksByUserAndTaskList(currentUser.UserID, currentTaskList.TaskListID);

            if (selected != "All")
                tasks = tasks.Where(t => t.Priority.Equals(selected, StringComparison.OrdinalIgnoreCase)).ToList();

            DisplayTasks(tasks);
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (currentTaskList == null) return;
            var selected = e.Start.Date;
            var tasks = taskService.GetTasksByUserAndTaskList(currentUser.UserID, currentTaskList.TaskListID)
                                   .Where(t => t.DueDate.HasValue && t.DueDate.Value.Date == selected)
                                   .ToList();

            DisplayTasks(tasks);
        }

        private void lvTaskSummary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTaskSummary.SelectedItems.Count == 0) return;
            var task = lvTaskSummary.SelectedItems[0].Tag as AppTask;
            if (task == null) return;

            lvTaskDetails.Items.Clear();
            lvTaskDetails.Items.Add(new ListViewItem(new[] { "Title", task.Title }));
            lvTaskDetails.Items.Add(new ListViewItem(new[] { "Description", task.Description }));
            lvTaskDetails.Items.Add(new ListViewItem(new[] { "Status", task.Status }));
            lvTaskDetails.Items.Add(new ListViewItem(new[] { "Due Date", task.DueDate?.ToString("g") ?? "N/A" }));
            lvTaskDetails.Items.Add(new ListViewItem(new[] { "Priority", task.Priority }));
        }

        private void LoadTasksByTaskList(int taskListId)
        {
            var tasks = taskService.GetTasksByUserAndTaskList(currentUser.UserID, taskListId);

            // Bold dates with tasks
            calendar.BoldedDates = tasks
                .Where(t => t.DueDate.HasValue)
                .Select(t => t.DueDate.Value.Date)
                .Distinct()
                .ToArray();

            DisplayTasks(tasks);
        }

        private void DisplayTasks(List<AppTask> tasks)
        {
            lvTaskSummary.Items.Clear();

            foreach (var task in tasks)
            {
                var item = new ListViewItem(task.TaskID.ToString());
                item.SubItems.Add(task.Title);
                item.Tag = task;

                switch (task.Priority?.ToLower())
                {
                    case "low": item.BackColor = Color.LightGreen; break;
                    case "medium": item.BackColor = Color.Khaki; break;
                    case "high": item.BackColor = Color.Salmon; break;
                }

                lvTaskSummary.Items.Add(item);
            }

            lvTaskDetails.Items.Clear();
        }
    }
}

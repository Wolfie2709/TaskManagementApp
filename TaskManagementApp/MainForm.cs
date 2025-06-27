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

        public MainForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            LoadTaskSummaries();
        }

        private void LoadTaskSummaries()
        {
            lvTaskSummary.Items.Clear();
            var tasks = taskService.GetTasksByUser(currentUser.UserID);

            foreach (AppTask task in tasks)
            {
                var item = new ListViewItem(task.TaskID.ToString());
                item.SubItems.Add(task.Title);
                item.Tag = task;
                lvTaskSummary.Items.Add(item);
            }
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
            AddTask form = new AddTask(currentUser);
            form.ShowDialog();
            LoadTaskSummaries(); // Refresh the list
        }

        private void btnTaskLists_Click(object sender, EventArgs e)
        {
            TaskListForm form = new TaskListForm(currentUser);
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            new LoginForm().Show();
        }
    }
}
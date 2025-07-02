using System;
using System.Windows.Forms;
using TaskManagementApp.Models;

namespace TaskManagementApp
{
    public partial class AddTask : Form
    {
        private readonly User currentUser;
        private readonly TaskService taskService = new TaskService();
        private readonly TaskList currentList;


        public AddTask(User user, TaskList taskList = null)
        {
            InitializeComponent();
            currentUser = user;
            currentList = taskList;

            cbPriority.SelectedIndex = 1; // Medium
            cbStatus.SelectedIndex = 0;   // To Do
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaskName.Text))
            {
                MessageBox.Show("Task name is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newTask = new Models.Task
            {
                UserID = currentUser.UserID,
                TaskListID = currentList?.TaskListID, // ✅ Add this line
                Title = txtTaskName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                Status = cbStatus.SelectedItem?.ToString() ?? "To Do",
                DueDate = dtpDueDate.Value.Date,
                Priority = cbPriority.SelectedItem?.ToString() ?? "Medium",
                CreatedAt = DateTime.Now
            };


            bool success = taskService.AddTask(newTask);

            if (success)
            {
                MessageBox.Show("Task added successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add task.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
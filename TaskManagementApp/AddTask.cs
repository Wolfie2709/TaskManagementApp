using System;
using System.Windows.Forms;
using TaskManagementApp.Models;
using AppTask = TaskManagementApp.Models.Task;


namespace TaskManagementApp
{
    public partial class AddTask : Form
    {
        private readonly User currentUser;
        private readonly TaskService taskService = new TaskService();
        private readonly TaskList currentTaskList;
        private readonly AppTask editingTask;

        public AddTask(User user, TaskList taskList, AppTask taskToEdit = null)
        {
            InitializeComponent();

            currentUser = user;
            currentTaskList = taskList;
            editingTask = taskToEdit;

            if (editingTask != null)
            {
                this.Text = "Edit Task";
                btnSubmit.Text = "Update Task";

                txtTitle.Text = editingTask.Title;
                txtDescription.Text = editingTask.Description;
                cbStatus.SelectedItem = editingTask.Status;
                cbPriority.SelectedItem = editingTask.Priority;

                if (editingTask.DueDate.HasValue)
                {
                    dtpDueDate.Value = editingTask.DueDate.Value;
                    dtpDueDate.Checked = true;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Task title is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (editingTask == null)
            {
                // Add new task
                var newTask = new AppTask
                {
                    UserID = currentUser.UserID,
                    TaskListID = currentTaskList?.TaskListID ?? 0,
                    Title = txtTitle.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                    Status = cbStatus.SelectedItem?.ToString() ?? "To Do",
                    DueDate = dtpDueDate.Checked ? dtpDueDate.Value.Date : (DateTime?)null,
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
            else
            {
                // Edit existing task
                editingTask.Title = txtTitle.Text.Trim();
                editingTask.Description = txtDescription.Text.Trim();
                editingTask.Status = cbStatus.SelectedItem?.ToString() ?? "To Do";
                editingTask.DueDate = dtpDueDate.Checked ? dtpDueDate.Value.Date : (DateTime?)null;
                editingTask.Priority = cbPriority.SelectedItem?.ToString() ?? "Medium";

                bool success = taskService.UpdateTask(editingTask);

                if (success)
                {
                    MessageBox.Show("Task updated successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update task.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

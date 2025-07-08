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

            // Enable or disable the date picker based on checkbox state
            chkEnableDate.CheckedChanged += ChkEnableDate_CheckedChanged;

            currentUser = user;
            currentTaskList = taskList;
            editingTask = taskToEdit;

            // If we're editing an existing task, populate the fields
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
                    chkEnableDate.Checked = true;
                    dtpDueDate.Enabled = true;
                }
                else
                {
                    chkEnableDate.Checked = false;
                    dtpDueDate.Enabled = false;
                }
            }
            else
            {
                this.Text = "Add New Task";
                btnSubmit.Text = "Add Task";

                cbStatus.SelectedIndex = 0;
                cbPriority.SelectedIndex = 1;

                chkEnableDate.Checked = false;
                dtpDueDate.Enabled = false;
            }
        }

        private void ChkEnableDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpDueDate.Enabled = chkEnableDate.Checked;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Title is required
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Task title is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prevent due date in the past if enabled
            if (chkEnableDate.Checked && dtpDueDate.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Due date cannot be in the past.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string title = txtTitle.Text.Trim();
            string description = txtDescription.Text.Trim();
            string status = cbStatus.SelectedItem?.ToString() ?? "To Do";
            string priority = cbPriority.SelectedItem?.ToString() ?? "Medium";
            DateTime? dueDate = chkEnableDate.Checked ? dtpDueDate.Value.Date : (DateTime?)null;

            if (editingTask == null)
            {
                // Create a new task
                var newTask = new AppTask
                {
                    UserID = currentUser.UserID,
                    TaskListID = currentTaskList?.TaskListID ?? 0,
                    Title = title,
                    Description = description,
                    Status = status,
                    DueDate = dueDate,
                    Priority = priority,
                    CreatedAt = DateTime.Now
                };

                bool success = taskService.AddTask(newTask);

                if (success)
                {
                    MessageBox.Show("✅ Task added successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("❌ Failed to add task.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Update existing task
                editingTask.Title = title;
                editingTask.Description = description;
                editingTask.Status = status;
                editingTask.DueDate = dueDate;
                editingTask.Priority = priority;

                bool success = taskService.UpdateTask(editingTask);

                if (success)
                {
                    MessageBox.Show("✅ Task updated successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("❌ Failed to update task.", "Error",
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

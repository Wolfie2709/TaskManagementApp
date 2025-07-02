using System;
using System.Windows.Forms;
using TaskManagementApp.Models;

namespace TaskManagementApp
{
    public partial class AddTaskListForm : Form
    {
        public TaskList NewTaskList { get; private set; }
        private readonly User currentUser;

        public AddTaskListForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("List name is required.", "Validation Error");
                return;
            }

            NewTaskList = new TaskList
            {
                Name = txtName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                UserID = currentUser.UserID
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

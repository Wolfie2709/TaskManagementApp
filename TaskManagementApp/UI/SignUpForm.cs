using System;
using System.Windows.Forms;
using TaskManagementApp.Models;

namespace TaskManagementApp
{
    public partial class SignUpForm : Form
    {
        private UserService userService = new UserService(); // Fix: Use UserService instead of TaskService

        public SignUpForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None; // Bỏ viền gốc
            this.StartPosition = FormStartPosition.CenterScreen;

            var borderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm();
            borderlessForm.ContainerControl = this;

            // Add event handler
            btnRegister.Click += btnRegister_Click;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Add validation
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User user = new User
            {
                Username = txtUsername.Text.Trim(),
                PasswordHash = txtPassword.Text.Trim(), // In production, hash this!
                FullName = txtFullName.Text.Trim()
            };

            if (userService.SignUp(user))
            {
                MessageBox.Show("Registration successful!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // back to login
            }
            else
            {
                MessageBox.Show("Username already exists.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
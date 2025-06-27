using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagementApp
{
    public partial class LoginForm : Form
    {
        private UserService userService = new UserService();

        public LoginForm()
        {
            InitializeComponent();

            // Attach click events
            buttonLI.Click += buttonLI_Click;
            buttonSU.Click += buttonSU_Click;
        }

        private void buttonLI_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            var user = userService.Login(username, password);

            if (user != null)
            {
                MessageBox.Show($"Welcome, {user.FullName}!");
                this.Hide();

                MainForm mainForm = new MainForm(user);
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSU_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Optional: Autofocus or default text
        }
    }
}
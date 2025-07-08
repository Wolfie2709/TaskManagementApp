using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Drawing;

namespace TaskManagementApp
{
    partial class AddTaskListForm
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2TextBox txtName;
        private Guna2TextBox txtDescription;
        private Guna2Button btnSave;
        private Guna2Button btnCancel;
        private Label lblName;
        private Label lblDescription;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtName = new Guna2TextBox();
            this.txtDescription = new Guna2TextBox();
            this.btnSave = new Guna2Button();
            this.btnCancel = new Guna2Button();
            this.lblName = new Label();
            this.lblDescription = new Label();

            // 
            // lblName
            // 
            lblName.Text = "📋 List Name:";
            lblName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(30, 30);
            lblName.Size = new Size(100, 25);

            // 
            // txtName
            // 
            txtName.PlaceholderText = "Enter task list name";
            txtName.Location = new Point(140, 30);
            txtName.Size = new Size(250, 30);
            txtName.BorderRadius = 6;
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.FillColor = Color.FromArgb(240, 240, 240);

            // 
            // lblDescription
            // 
            lblDescription.Text = "📝 Description:";
            lblDescription.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDescription.ForeColor = Color.White;
            lblDescription.Location = new Point(30, 80);
            lblDescription.Size = new Size(100, 25);

            // 
            // txtDescription
            // 
            txtDescription.PlaceholderText = "Enter description";
            txtDescription.Location = new Point(140, 80);
            txtDescription.Size = new Size(250, 80);
            txtDescription.BorderRadius = 6;
            txtDescription.Multiline = true;
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.FillColor = Color.FromArgb(240, 240, 240);

            // 
            // btnSave
            // 
            btnSave.Text = "💾 Save";
            btnSave.Size = new Size(100, 40);
            btnSave.Location = new Point(140, 180);
            btnSave.BorderRadius = 6;
            btnSave.FillColor = Color.FromArgb(45, 140, 240);
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Click += new EventHandler(this.btnSave_Click);

            // 
            // btnCancel
            // 
            btnCancel.Text = "❌ Cancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.Location = new Point(290, 180);
            btnCancel.BorderRadius = 6;
            btnCancel.FillColor = Color.FromArgb(220, 50, 60);
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Click += new EventHandler(this.btnCancel_Click);

            // 
            // AddTaskListForm
            // 
            this.BackColor = Color.FromArgb(35, 40, 50);
            this.ClientSize = new Size(430, 250);
            this.Controls.Add(lblName);
            this.Controls.Add(txtName);
            this.Controls.Add(lblDescription);
            this.Controls.Add(txtDescription);
            this.Controls.Add(btnSave);
            this.Controls.Add(btnCancel);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "🗂️ Add Task List";
        }
    }
}

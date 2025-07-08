using Guna.UI2.WinForms;
using System.Drawing;
using System;
using System.Windows.Forms;

namespace TaskManagementApp
{
    partial class AddTask
    {
        private Guna2TextBox txtTitle;
        private Guna2TextBox txtDescription;
        private Guna2ComboBox cbPriority;
        private Guna2ComboBox cbStatus;
        private Guna2DateTimePicker dtpDueDate;
        private Guna2CheckBox chkEnableDate;
        private Guna2Button btnSubmit;
        private Guna2Button btnCancel;
        private Guna2ShadowPanel panelWrapper;

        private void InitializeComponent()
        {
            this.txtTitle = new Guna2TextBox();
            this.txtDescription = new Guna2TextBox();
            this.cbPriority = new Guna2ComboBox();
            this.cbStatus = new Guna2ComboBox();
            this.dtpDueDate = new Guna2DateTimePicker();
            this.chkEnableDate = new Guna2CheckBox();
            this.btnSubmit = new Guna2Button();
            this.btnCancel = new Guna2Button();
            this.panelWrapper = new Guna2ShadowPanel();

            // 
            // panelWrapper
            // 
            this.panelWrapper.BackColor = Color.FromArgb(40, 45, 55);
            this.panelWrapper.Size = new Size(440, 420);
            this.panelWrapper.Location = new Point(20, 20);
            this.panelWrapper.ShadowColor = Color.Black;
            this.panelWrapper.ShadowDepth = 4;
            this.panelWrapper.FillColor = Color.FromArgb(50, 55, 65);
            this.panelWrapper.Controls.AddRange(new Control[] {
        txtTitle, txtDescription, dtpDueDate, chkEnableDate,
        cbPriority, cbStatus, btnSubmit, btnCancel
    });

            // 
            // txtTitle
            // 
            txtTitle.PlaceholderText = "Enter task title...";
            txtTitle.Location = new Point(30, 30);
            txtTitle.Size = new Size(380, 40);
            txtTitle.BorderRadius = 6;

            // 
            // txtDescription
            // 
            txtDescription.PlaceholderText = "Enter task description...";
            txtDescription.Location = new Point(30, 80);
            txtDescription.Size = new Size(380, 70);
            txtDescription.Multiline = true;
            txtDescription.BorderRadius = 6;

            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(30, 160);
            dtpDueDate.Size = new Size(240, 36);
            dtpDueDate.BorderRadius = 6;
            dtpDueDate.Format = DateTimePickerFormat.Short;

            // 
            // chkEnableDate
            // 
            chkEnableDate.Text = "Enable Due Date";
            chkEnableDate.Location = new Point(290, 160);
            chkEnableDate.Size = new Size(120, 36);
            chkEnableDate.Checked = false;
           

            // 
            // cbPriority
            // 
            cbPriority.Items.AddRange(new object[] { "Low", "Medium", "High" });
            cbPriority.SelectedIndex = 1;
            cbPriority.Location = new Point(30, 210);
            cbPriority.Size = new Size(180, 36);
            cbPriority.BorderRadius = 6;
            cbPriority.DropDownStyle = ComboBoxStyle.DropDownList;

            // 
            // cbStatus
            // 
            cbStatus.Items.AddRange(new object[] { "To Do", "In Progress", "Done" });
            cbStatus.SelectedIndex = 0;
            cbStatus.Location = new Point(230, 210);
            cbStatus.Size = new Size(180, 36);
            cbStatus.BorderRadius = 6;
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            // 
            // btnSubmit
            // 
            btnSubmit.Text = "Save Task";
            btnSubmit.Location = new Point(110, 280);
            btnSubmit.Size = new Size(100, 40);
            btnSubmit.BorderRadius = 8;
            btnSubmit.FillColor = Color.FromArgb(0, 192, 0);
            btnSubmit.Click += new EventHandler(this.btnSubmit_Click);

            // 
            // btnCancel
            // 
            btnCancel.Text = "Cancel";
            btnCancel.Location = new Point(230, 280);
            btnCancel.Size = new Size(100, 40);
            btnCancel.BorderRadius = 8;
            btnCancel.FillColor = Color.FromArgb(192, 0, 0);
            btnCancel.Click += new EventHandler(this.btnCancel_Click);

            // 
            // AddTask Form
            // 
            this.ClientSize = new Size(480, 480);
            this.Controls.Add(panelWrapper);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Add New Task";
            this.BackColor = Color.FromArgb(30, 35, 45);
        }
    }
}
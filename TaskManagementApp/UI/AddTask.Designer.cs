using Guna.UI2.WinForms;
using System.Drawing;
using System;
using System.Windows.Forms;
using TaskManagementApp.Logic;
using TaskManagementApp.DAL;
using TaskManagementApp.Services;

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
        private Guna.UI2.WinForms.Guna2ComboBox cbCategory;
        private readonly CategoryService categoryService = new CategoryService();

        private void InitializeComponent()
        {
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbPriority = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpDueDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.chkEnableDate = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.panelWrapper = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.cbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.BorderRadius = 6;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultText = "";
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTitle.Location = new System.Drawing.Point(30, 30);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PlaceholderText = "Enter task title...";
            this.txtTitle.SelectedText = "";
            this.txtTitle.Size = new System.Drawing.Size(380, 40);
            this.txtTitle.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderRadius = 6;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescription.Location = new System.Drawing.Point(30, 80);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "Enter task description...";
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(380, 70);
            this.txtDescription.TabIndex = 1;
            // 
            // cbPriority
            // 
            this.cbPriority.BackColor = System.Drawing.Color.Transparent;
            this.cbPriority.BorderRadius = 6;
            this.cbPriority.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPriority.FocusedColor = System.Drawing.Color.Empty;
            this.cbPriority.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbPriority.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbPriority.ItemHeight = 30;
            this.cbPriority.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.cbPriority.Location = new System.Drawing.Point(30, 210);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(180, 36);
            this.cbPriority.TabIndex = 4;
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbStatus.BorderRadius = 6;
            this.cbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbStatus.ItemHeight = 30;
            this.cbStatus.Items.AddRange(new object[] {
            "To Do",
            "In Progress",
            "Done"});
            this.cbStatus.Location = new System.Drawing.Point(230, 210);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(180, 36);
            this.cbStatus.TabIndex = 5;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.BorderRadius = 6;
            this.dtpDueDate.Checked = true;
            this.dtpDueDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(30, 160);
            this.dtpDueDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDueDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(240, 36);
            this.dtpDueDate.TabIndex = 2;
            this.dtpDueDate.Value = new System.DateTime(2025, 7, 9, 3, 1, 40, 754);
            // 
            // chkEnableDate
            // 
            this.chkEnableDate.CheckedState.BorderRadius = 0;
            this.chkEnableDate.CheckedState.BorderThickness = 0;
            this.chkEnableDate.Location = new System.Drawing.Point(290, 160);
            this.chkEnableDate.Name = "chkEnableDate";
            this.chkEnableDate.Size = new System.Drawing.Size(120, 36);
            this.chkEnableDate.TabIndex = 3;
            this.chkEnableDate.Text = "Enable Due Date";
            this.chkEnableDate.UncheckedState.BorderRadius = 0;
            this.chkEnableDate.UncheckedState.BorderThickness = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BorderRadius = 8;
            this.btnSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(30, 344);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 40);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Save Task";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 8;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(324, 344);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelWrapper
            // 
            this.panelWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.panelWrapper.Controls.Add(this.cbCategory);
            this.panelWrapper.Controls.Add(this.txtTitle);
            this.panelWrapper.Controls.Add(this.txtDescription);
            this.panelWrapper.Controls.Add(this.dtpDueDate);
            this.panelWrapper.Controls.Add(this.chkEnableDate);
            this.panelWrapper.Controls.Add(this.cbPriority);
            this.panelWrapper.Controls.Add(this.cbStatus);
            this.panelWrapper.Controls.Add(this.btnSubmit);
            this.panelWrapper.Controls.Add(this.btnCancel);
            this.panelWrapper.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.panelWrapper.Location = new System.Drawing.Point(20, 20);
            this.panelWrapper.Name = "panelWrapper";
            this.panelWrapper.ShadowColor = System.Drawing.Color.Black;
            this.panelWrapper.ShadowDepth = 4;
            this.panelWrapper.Size = new System.Drawing.Size(440, 420);
            this.panelWrapper.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbCategory.BorderRadius = 6;
            this.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbCategory.ItemHeight = 30;
            cbCategory.DataSource = categoryService.GetCategories(); // List<Category>
            cbCategory.DisplayMember = "Name";        // Show category name in UI
            cbCategory.ValueMember = "CategoryID";    // Used internally for saving

            this.cbCategory.Location = new System.Drawing.Point(30, 273);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(380, 36);
            this.cbCategory.TabIndex = 0;
            // 
            // AddTask
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(480, 480);
            this.Controls.Add(this.panelWrapper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Task";
            this.panelWrapper.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace TaskManagementApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2Panel sidebarPanel;
        private Guna.UI2.WinForms.Guna2Button btnToday;
        private Guna.UI2.WinForms.Guna2Button btnUpcoming;
        private Guna.UI2.WinForms.Guna2Button btnTaskLists;
        private Guna.UI2.WinForms.Guna2Button btnAddList;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2CheckBox chkEnableDateFilter;
        private Guna.UI2.WinForms.Guna2Button btnEditTask;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblWelcome;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private Guna.UI2.WinForms.Guna2Panel panelSummary;
        private Guna.UI2.WinForms.Guna2Panel panelDetails;
        private System.Windows.Forms.ListView lvTaskSummary;
        private System.Windows.Forms.ListView lvTaskDetails;
        private Guna.UI2.WinForms.Guna2Panel panelFilter;
        private Guna.UI2.WinForms.Guna2TextBox taskNameBox;
        private Guna.UI2.WinForms.Guna2ComboBox priorityBox;
        private Guna.UI2.WinForms.Guna2ComboBox statusBox;
        private Guna.UI2.WinForms.Guna2DateTimePicker datePicker;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Button btnAddTask;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCurrentList;
        private System.Windows.Forms.Label lblListName;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.sidebarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCurrentList = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnEditTask = new Guna.UI2.WinForms.Guna2Button();
            this.btnToday = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpcoming = new Guna.UI2.WinForms.Guna2Button();
            this.btnTaskLists = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddList = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddTask = new Guna.UI2.WinForms.Guna2Button();
            this.lblListName = new System.Windows.Forms.Label();
            this.lblWelcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.lvTaskSummary = new System.Windows.Forms.ListView();
            this.panelSummary = new Guna.UI2.WinForms.Guna2Panel();
            this.lvTaskDetails = new System.Windows.Forms.ListView();
            this.panelDetails = new Guna.UI2.WinForms.Guna2Panel();
            this.panelFilter = new Guna.UI2.WinForms.Guna2Panel();
            this.taskNameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.priorityBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.statusBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.datePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.chkEnableDateFilter = new Guna.UI2.WinForms.Guna2CheckBox();
            this.sidebarPanel.SuspendLayout();
            this.panelSummary.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.sidebarPanel.Controls.Add(this.lblCurrentList);
            this.sidebarPanel.Controls.Add(this.btnEditTask);
            this.sidebarPanel.Controls.Add(this.btnToday);
            this.sidebarPanel.Controls.Add(this.btnUpcoming);
            this.sidebarPanel.Controls.Add(this.btnTaskLists);
            this.sidebarPanel.Controls.Add(this.btnAddList);
            this.sidebarPanel.Controls.Add(this.btnLogout);
            this.sidebarPanel.Controls.Add(this.btnAddTask);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(180, 550);
            this.sidebarPanel.TabIndex = 0;
            // 
            // lblCurrentList
            // 
            this.lblCurrentList.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCurrentList.ForeColor = System.Drawing.Color.White;
            this.lblCurrentList.Location = new System.Drawing.Point(10, 303);
            this.lblCurrentList.Name = "lblCurrentList";
            this.lblCurrentList.Size = new System.Drawing.Size(147, 19);
            this.lblCurrentList.TabIndex = 0;
            this.lblCurrentList.Text = "📋 No task list selected";
            // 
            // btnEditTask
            // 
            this.btnEditTask.BorderRadius = 8;
            this.btnEditTask.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnEditTask.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnEditTask.ForeColor = System.Drawing.Color.White;
            this.btnEditTask.Location = new System.Drawing.Point(10, 244);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(160, 40);
            this.btnEditTask.TabIndex = 3;
            this.btnEditTask.Text = "✏️ Edit Task";
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // btnToday
            // 
            this.btnToday.BorderRadius = 8;
            this.btnToday.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnToday.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnToday.ForeColor = System.Drawing.Color.White;
            this.btnToday.Location = new System.Drawing.Point(12, 12);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(160, 40);
            this.btnToday.TabIndex = 0;
            this.btnToday.Text = "📅 Today";
            // 
            // btnUpcoming
            // 
            this.btnUpcoming.BorderRadius = 8;
            this.btnUpcoming.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnUpcoming.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUpcoming.ForeColor = System.Drawing.Color.White;
            this.btnUpcoming.Location = new System.Drawing.Point(12, 60);
            this.btnUpcoming.Name = "btnUpcoming";
            this.btnUpcoming.Size = new System.Drawing.Size(160, 40);
            this.btnUpcoming.TabIndex = 1;
            this.btnUpcoming.Text = "🗓️ Upcoming";
            // 
            // btnTaskLists
            // 
            this.btnTaskLists.BorderRadius = 8;
            this.btnTaskLists.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnTaskLists.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTaskLists.ForeColor = System.Drawing.Color.White;
            this.btnTaskLists.Location = new System.Drawing.Point(12, 106);
            this.btnTaskLists.Name = "btnTaskLists";
            this.btnTaskLists.Size = new System.Drawing.Size(160, 40);
            this.btnTaskLists.TabIndex = 2;
            this.btnTaskLists.Text = "📋 Task Lists";
            this.btnTaskLists.Click += new System.EventHandler(this.btnTaskLists_Click);
            // 
            // btnAddList
            // 
            this.btnAddList.BorderRadius = 8;
            this.btnAddList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnAddList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddList.ForeColor = System.Drawing.Color.White;
            this.btnAddList.Location = new System.Drawing.Point(12, 198);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(160, 40);
            this.btnAddList.TabIndex = 3;
            this.btnAddList.Text = "➕ Add List";
            // 
            // btnLogout
            // 
            this.btnLogout.BorderRadius = 8;
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(10, 498);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(160, 40);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "🚪 Logout";
            // 
            // btnAddTask
            // 
            this.btnAddTask.BorderRadius = 8;
            this.btnAddTask.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(65)))));
            this.btnAddTask.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.Location = new System.Drawing.Point(12, 152);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(160, 40);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.Text = "➕ Add Task";
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // lblListName
            // 
            this.lblListName.AutoSize = true;
            this.lblListName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblListName.Location = new System.Drawing.Point(1008, 244);
            this.lblListName.Name = "lblListName";
            this.lblListName.Size = new System.Drawing.Size(125, 19);
            this.lblListName.TabIndex = 5;
            this.lblListName.Text = "List: Not Selected";
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.Location = new System.Drawing.Point(200, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(135, 27);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome, User";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(1002, 60);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 2;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // lvTaskSummary
            // 
            this.lvTaskSummary.FullRowSelect = true;
            this.lvTaskSummary.HideSelection = false;
            this.lvTaskSummary.Location = new System.Drawing.Point(10, 10);
            this.lvTaskSummary.Name = "lvTaskSummary";
            this.lvTaskSummary.Size = new System.Drawing.Size(230, 380);
            this.lvTaskSummary.TabIndex = 0;
            this.lvTaskSummary.UseCompatibleStateImageBehavior = false;
            this.lvTaskSummary.View = System.Windows.Forms.View.Details;
            lvTaskSummary.SelectedIndexChanged += lvTaskSummary_SelectedIndexChanged;
            lvTaskSummary.Columns.Add("ID", 50);
            lvTaskSummary.Columns.Add("Title", 160);
            // 
            // panelSummary
            // 
            this.panelSummary.BackColor = System.Drawing.Color.Transparent;
            this.panelSummary.BorderRadius = 10;
            this.panelSummary.Controls.Add(this.lvTaskSummary);
            this.panelSummary.Location = new System.Drawing.Point(200, 60);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.ShadowDecoration.Enabled = true;
            this.panelSummary.Size = new System.Drawing.Size(250, 400);
            this.panelSummary.TabIndex = 3;
            // 
            // lvTaskDetails
            // 
            this.lvTaskDetails.HideSelection = false;
            this.lvTaskDetails.Location = new System.Drawing.Point(10, 10);
            this.lvTaskDetails.Name = "lvTaskDetails";
            this.lvTaskDetails.Size = new System.Drawing.Size(500, 380);
            this.lvTaskDetails.TabIndex = 0;
            this.lvTaskDetails.UseCompatibleStateImageBehavior = false;
            this.lvTaskDetails.View = System.Windows.Forms.View.Details;
            lvTaskDetails.Columns.Add("Property", 150);
            lvTaskDetails.Columns.Add("Value", 350);

            // 
            // panelDetails
            // 
            this.panelDetails.BackColor = System.Drawing.Color.Transparent;
            this.panelDetails.BorderRadius = 10;
            this.panelDetails.Controls.Add(this.lvTaskDetails);
            this.panelDetails.Location = new System.Drawing.Point(460, 60);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.ShadowDecoration.Enabled = true;
            this.panelDetails.Size = new System.Drawing.Size(520, 400);
            this.panelDetails.TabIndex = 4;
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.Transparent;
            this.panelFilter.BorderRadius = 10;
            this.panelFilter.Controls.Add(this.taskNameBox);
            this.panelFilter.Controls.Add(this.priorityBox);
            this.panelFilter.Controls.Add(this.statusBox);
            this.panelFilter.Controls.Add(this.datePicker);
            this.panelFilter.Controls.Add(this.btnSearch);
            this.panelFilter.Controls.Add(this.btnReset);
            this.panelFilter.Controls.Add(this.chkEnableDateFilter);
            this.panelFilter.Location = new System.Drawing.Point(200, 470);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.ShadowDecoration.Enabled = true;
            this.panelFilter.Size = new System.Drawing.Size(881, 50);
            this.panelFilter.TabIndex = 5;
            // 
            // taskNameBox
            // 
            this.taskNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.taskNameBox.DefaultText = "";
            this.taskNameBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.taskNameBox.Location = new System.Drawing.Point(20, 10);
            this.taskNameBox.Name = "taskNameBox";
            this.taskNameBox.PlaceholderText = "Search by title...";
            this.taskNameBox.SelectedText = "";
            this.taskNameBox.Size = new System.Drawing.Size(200, 30);
            this.taskNameBox.TabIndex = 0;
            // 
            // priorityBox
            // 
            this.priorityBox.BackColor = System.Drawing.Color.Transparent;
            this.priorityBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.priorityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priorityBox.FocusedColor = System.Drawing.Color.Empty;
            this.priorityBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.priorityBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.priorityBox.ItemHeight = 30;
            this.priorityBox.Location = new System.Drawing.Point(230, 10);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(120, 36);
            this.priorityBox.TabIndex = 1;
            // 
            // statusBox
            // 
            this.statusBox.BackColor = System.Drawing.Color.Transparent;
            this.statusBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.statusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusBox.FocusedColor = System.Drawing.Color.Empty;
            this.statusBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.statusBox.ItemHeight = 30;
            this.statusBox.Location = new System.Drawing.Point(360, 10);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(120, 36);
            this.statusBox.TabIndex = 2;
            // 
            // datePicker
            // 
            this.datePicker.Checked = true;
            this.datePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(490, 10);
            this.datePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(140, 30);
            this.datePicker.TabIndex = 3;
            this.datePicker.Value = new System.DateTime(2025, 7, 8, 4, 53, 20, 988);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(746, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.FilterTasks);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(640, 10);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 30);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.ResetFilters);
            // 
            // chkEnableDateFilter
            // 
            this.chkEnableDateFilter.CheckedState.BorderRadius = 0;
            this.chkEnableDateFilter.CheckedState.BorderThickness = 0;
            this.chkEnableDateFilter.Location = new System.Drawing.Point(680, 45);
            this.chkEnableDateFilter.Name = "chkEnableDateFilter";
            this.chkEnableDateFilter.Size = new System.Drawing.Size(140, 30);
            this.chkEnableDateFilter.TabIndex = 5;
            this.chkEnableDateFilter.Text = "Enable Date Filter";
            this.chkEnableDateFilter.UncheckedState.BorderRadius = 0;
            this.chkEnableDateFilter.UncheckedState.BorderThickness = 0;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1247, 550);
            this.Controls.Add(this.lblListName);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.panelFilter);
            this.Name = "MainForm";
            this.Text = "Task Manager";
            this.sidebarPanel.ResumeLayout(false);
            this.sidebarPanel.PerformLayout();
            this.panelSummary.ResumeLayout(false);
            this.panelDetails.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Guna2Button CreateSidebarButton(string text, int top)
        {
            return new Guna2Button
            {
                Text = text,
                Font = new System.Drawing.Font("Segoe UI", 10F),
                ForeColor = System.Drawing.Color.White,
                FillColor = System.Drawing.Color.FromArgb(50, 55, 65),
                BorderRadius = 8,
                Size = new System.Drawing.Size(160, 40),
                Location = new System.Drawing.Point(10, top)
            };
        }
    }
}

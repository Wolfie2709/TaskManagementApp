using System.Windows.Forms;

namespace TaskManagementApp
{
    public partial class MainForm : Form
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.ListView lvTaskSummary;
        private System.Windows.Forms.ListView lvTaskDetails;
        private Guna.UI2.WinForms.Guna2Button btnAddTask;
        private Guna.UI2.WinForms.Guna2Button btnTaskLists;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnEditTask;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnFilterPriority;
        private Guna.UI2.WinForms.Guna2ControlBox exitMainButton;
        private Guna.UI2.WinForms.Guna2Button btnDeleteTask;
        private TextBox txtSearch;
        private ComboBox cbPriorityFilter;
        private ColumnHeader Task;
        private ColumnHeader Details;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lvTaskSummary = new System.Windows.Forms.ListView();
            this.lvTaskDetails = new System.Windows.Forms.ListView();
            this.btnAddTask = new Guna.UI2.WinForms.Guna2Button();
            this.btnTaskLists = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditTask = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnFilterPriority = new Guna.UI2.WinForms.Guna2Button();
            this.exitMainButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbPriorityFilter = new System.Windows.Forms.ComboBox();
            this.btnDeleteTask = new Guna.UI2.WinForms.Guna2Button();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // lvTaskSummary
            // 
            this.lvTaskSummary.FullRowSelect = true;
            this.lvTaskSummary.HideSelection = false;
            this.lvTaskSummary.Location = new System.Drawing.Point(30, 30);
            this.lvTaskSummary.Name = "lvTaskSummary";
            this.lvTaskSummary.Size = new System.Drawing.Size(250, 400);
            this.lvTaskSummary.TabIndex = 0;
            this.lvTaskSummary.UseCompatibleStateImageBehavior = false;
            this.lvTaskSummary.View = System.Windows.Forms.View.Details;
            this.lvTaskSummary.SelectedIndexChanged += new System.EventHandler(this.lvTaskSummary_SelectedIndexChanged);
            this.lvTaskSummary.Columns.Add("ID", 50);
            this.lvTaskSummary.Columns.Add("Title", 180);
            // 
            // lvTaskDetails
            // 
            this.lvTaskDetails.HideSelection = false;
            this.lvTaskDetails.Location = new System.Drawing.Point(300, 30);
            this.lvTaskDetails.Name = "lvTaskDetails";
            this.lvTaskDetails.Size = new System.Drawing.Size(550, 400);
            this.lvTaskDetails.TabIndex = 1;
            this.lvTaskDetails.UseCompatibleStateImageBehavior = false;
            this.lvTaskDetails.View = System.Windows.Forms.View.Details;
            this.lvTaskDetails.Columns.Add("Task", 150);
            this.lvTaskDetails.Columns.Add("Details", 380);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.Location = new System.Drawing.Point(101, 450);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(100, 30);
            this.btnAddTask.TabIndex = 2;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnTaskLists
            // 
            this.btnTaskLists.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTaskLists.ForeColor = System.Drawing.Color.White;
            this.btnTaskLists.Location = new System.Drawing.Point(300, 450);
            this.btnTaskLists.Name = "btnTaskLists";
            this.btnTaskLists.Size = new System.Drawing.Size(100, 30);
            this.btnTaskLists.TabIndex = 3;
            this.btnTaskLists.Text = "Task Lists";
            this.btnTaskLists.Click += new System.EventHandler(this.btnTaskLists_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FillColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(997, 450);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 30);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnEditTask
            // 
            this.btnEditTask.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditTask.ForeColor = System.Drawing.Color.White;
            this.btnEditTask.Location = new System.Drawing.Point(543, 450);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(90, 30);
            this.btnEditTask.TabIndex = 5;
            this.btnEditTask.Text = "Edit Task";
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(870, 300);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFilterPriority
            // 
            this.btnFilterPriority.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFilterPriority.ForeColor = System.Drawing.Color.White;
            this.btnFilterPriority.Location = new System.Drawing.Point(1027, 204);
            this.btnFilterPriority.Name = "btnFilterPriority";
            this.btnFilterPriority.Size = new System.Drawing.Size(70, 30);
            this.btnFilterPriority.TabIndex = 9;
            this.btnFilterPriority.Text = "Filter";
            this.btnFilterPriority.Click += new System.EventHandler(this.btnFilterPriority_Click);
            // 
            // exitMainButton
            // 
            this.exitMainButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitMainButton.FillColor = System.Drawing.Color.Transparent;
            this.exitMainButton.IconColor = System.Drawing.Color.Red;
            this.exitMainButton.Location = new System.Drawing.Point(1092, 2);
            this.exitMainButton.Name = "exitMainButton";
            this.exitMainButton.Size = new System.Drawing.Size(30, 30);
            this.exitMainButton.TabIndex = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(870, 257);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 20);
            this.txtSearch.TabIndex = 6;
            // 
            // cbPriorityFilter
            // 
            this.cbPriorityFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPriorityFilter.Items.AddRange(new object[] {
            "All",
            "Low",
            "Medium",
            "High"});
            this.cbPriorityFilter.Location = new System.Drawing.Point(870, 204);
            this.cbPriorityFilter.Name = "cbPriorityFilter";
            this.cbPriorityFilter.Size = new System.Drawing.Size(150, 21);
            this.cbPriorityFilter.TabIndex = 8;
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.BorderRadius = 15;
            this.btnDeleteTask.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteTask.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDeleteTask.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTask.Location = new System.Drawing.Point(780, 450);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(70, 30);
            this.btnDeleteTask.TabIndex = 12;
            this.btnDeleteTask.Text = "Delete";
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(870, 30);
            this.calendar.MaxSelectionCount = 1;
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 11;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateChanged);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1123, 510);
            this.Controls.Add(this.lvTaskSummary);
            this.Controls.Add(this.lvTaskDetails);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.btnTaskLists);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnEditTask);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbPriorityFilter);
            this.Controls.Add(this.btnFilterPriority);
            this.Controls.Add(this.exitMainButton);
            this.Controls.Add(this.calendar);
            this.Controls.Add(this.btnDeleteTask);
            this.Name = "MainForm";
            this.Text = "Task Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

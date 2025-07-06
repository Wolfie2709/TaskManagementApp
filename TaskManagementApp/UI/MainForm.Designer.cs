using System.Drawing;
using System;
using System.Windows.Forms;

namespace TaskManagementApp
{
    public partial class MainForm : Form
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private Guna.UI2.WinForms.Guna2Panel panelSidebar;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private Guna.UI2.WinForms.Guna2Panel panelRight;
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
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private ComboBox cbPriorityFilter;
        private ColumnHeader Task;
        private ColumnHeader Details;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2BorderlessForm1.ContainerControl = this;
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddTask = new Guna.UI2.WinForms.Guna2Button();
            this.btnTaskLists = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditTask = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteTask = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.panelSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.lvTaskSummary = new System.Windows.Forms.ListView();
            this.lvTaskDetails = new System.Windows.Forms.ListView();
            this.panelRight = new Guna.UI2.WinForms.Guna2Panel();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.cbPriorityFilter = new System.Windows.Forms.ComboBox();
            this.btnFilterPriority = new Guna.UI2.WinForms.Guna2Button();
            this.exitMainButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelTop.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnAddTask);
            this.panelTop.Controls.Add(this.btnTaskLists);
            this.panelTop.Controls.Add(this.btnEditTask);
            this.panelTop.Controls.Add(this.btnDeleteTask);
            this.panelTop.Controls.Add(this.btnLogout);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.FillColor = System.Drawing.Color.White;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1200, 60);
            this.panelTop.TabIndex = 3;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.Location = new System.Drawing.Point(20, 15);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(180, 45);
            this.btnAddTask.TabIndex = 0;
            this.btnAddTask.Text = "+ Add Task";
            // 
            // btnTaskLists
            // 
            this.btnTaskLists.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTaskLists.ForeColor = System.Drawing.Color.White;
            this.btnTaskLists.Location = new System.Drawing.Point(287, 15);
            this.btnTaskLists.Name = "btnTaskLists";
            this.btnTaskLists.Size = new System.Drawing.Size(180, 45);
            this.btnTaskLists.TabIndex = 1;
            this.btnTaskLists.Text = "Task Lists";
            // 
            // btnEditTask
            // 
            this.btnEditTask.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditTask.ForeColor = System.Drawing.Color.White;
            this.btnEditTask.Location = new System.Drawing.Point(529, 15);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(180, 45);
            this.btnEditTask.TabIndex = 2;
            this.btnEditTask.Text = "Edit";
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.FillColor = System.Drawing.Color.OrangeRed;
            this.btnDeleteTask.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDeleteTask.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTask.Location = new System.Drawing.Point(760, 15);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(180, 45);
            this.btnDeleteTask.TabIndex = 3;
            this.btnDeleteTask.Text = "Delete";
            // 
            // btnLogout
            // 
            this.btnLogout.FillColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(950, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(180, 45);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            // 
            // 
            // panelSidebar
            // 
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.FillColor = System.Drawing.Color.WhiteSmoke;
            this.panelSidebar.Size = new System.Drawing.Size(150, 540);
            this.panelSidebar.ShadowDecoration.Parent = this;
            this.panelSidebar.BorderColor = System.Drawing.Color.LightGray;
            this.panelSidebar.BorderThickness = 1;

            // Add test label to make panel visible
            var lblSidebar = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblSidebar.Text = "Sidebar";
            lblSidebar.ForeColor = Color.DimGray;
            lblSidebar.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblSidebar.Location = new Point(10, 10);
            this.panelSidebar.Controls.Add(lblSidebar);


            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.lvTaskSummary);
            this.panelMain.Controls.Add(this.lvTaskDetails);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(150, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(10);
            this.panelMain.Size = new System.Drawing.Size(800, 540);
            this.panelMain.TabIndex = 0;
            // 
            // lvTaskSummary
            // 
            this.lvTaskSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvTaskSummary.FullRowSelect = true;
            this.lvTaskSummary.HideSelection = false;
            this.lvTaskSummary.Location = new System.Drawing.Point(10, 10);
            this.lvTaskSummary.Name = "lvTaskSummary";
            this.lvTaskSummary.Size = new System.Drawing.Size(780, 200);
            this.lvTaskSummary.TabIndex = 0;
            this.lvTaskSummary.UseCompatibleStateImageBehavior = false;
            this.lvTaskSummary.View = System.Windows.Forms.View.Details;
            this.lvTaskSummary.SelectedIndexChanged += new System.EventHandler(this.lvTaskSummary_SelectedIndexChanged);
            this.lvTaskSummary.Columns.Add("ID", 50);
            this.lvTaskSummary.Columns.Add("Title", 300);
            // 
            // lvTaskDetails
            // 
            this.lvTaskDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTaskDetails.HideSelection = false;
            this.lvTaskDetails.Location = new System.Drawing.Point(10, 10);
            this.lvTaskDetails.Name = "lvTaskDetails";
            this.lvTaskDetails.Size = new System.Drawing.Size(780, 520);
            this.lvTaskDetails.TabIndex = 1;
            this.lvTaskDetails.UseCompatibleStateImageBehavior = false;
            this.lvTaskDetails.View = System.Windows.Forms.View.Details;
            this.lvTaskDetails.Columns.Add("Field", 150);
            this.lvTaskDetails.Columns.Add("Value", 400);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.calendar);
            this.panelRight.Controls.Add(this.txtSearch);
            this.panelRight.Controls.Add(this.btnSearch);
            this.panelRight.Controls.Add(this.cbPriorityFilter);
            this.panelRight.Controls.Add(this.btnFilterPriority);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.FillColor = System.Drawing.Color.WhiteSmoke;
            this.panelRight.Location = new System.Drawing.Point(950, 60);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(10);
            this.panelRight.Size = new System.Drawing.Size(250, 540);
            this.panelRight.TabIndex = 2;
            // 
            // calendar
            // 
            this.calendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.calendar.Location = new System.Drawing.Point(10, 157);
            this.calendar.MaxSelectionCount = 1;
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 0;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(10, 121);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search tasks...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(230, 36);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(10, 76);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(230, 45);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbPriorityFilter
            // 
            this.cbPriorityFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbPriorityFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPriorityFilter.Items.AddRange(new object[] {
            "All",
            "Low",
            "Medium",
            "High"});
            this.cbPriorityFilter.Location = new System.Drawing.Point(10, 55);
            this.cbPriorityFilter.Name = "cbPriorityFilter";
            this.cbPriorityFilter.Size = new System.Drawing.Size(230, 21);
            this.cbPriorityFilter.TabIndex = 3;
            // 
            // btnFilterPriority
            // 
            this.btnFilterPriority.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilterPriority.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFilterPriority.ForeColor = System.Drawing.Color.White;
            this.btnFilterPriority.Location = new System.Drawing.Point(10, 10);
            this.btnFilterPriority.Name = "btnFilterPriority";
            this.btnFilterPriority.Size = new System.Drawing.Size(230, 45);
            this.btnFilterPriority.TabIndex = 4;
            this.btnFilterPriority.Text = "Filter by Priority";
            this.btnFilterPriority.Click += new System.EventHandler(this.btnFilterPriority_Click);
            // 
            // exitMainButton
            // 
            this.exitMainButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitMainButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.exitMainButton.IconColor = System.Drawing.Color.White;
            this.exitMainButton.Location = new System.Drawing.Point(0, 0);
            this.exitMainButton.Name = "exitMainButton";
            this.exitMainButton.Size = new System.Drawing.Size(45, 29);
            this.exitMainButton.TabIndex = 0;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelTop);
            this.Name = "MainForm";
            this.Text = "Task Management";
            this.panelTop.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
    }
}

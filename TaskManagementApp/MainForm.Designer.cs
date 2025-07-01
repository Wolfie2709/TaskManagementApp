using System.Windows.Forms;

namespace TaskManagementApp
{
    public partial class MainForm : Form
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MonthCalendar calendar;


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
            this.Task = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Details = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.exitMainButton = new Guna.UI2.WinForms.Guna2ControlBox();
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

            // Add columns for task summary
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

            // Add columns for task details
            this.lvTaskDetails.Columns.Add("Task", 150);
            this.lvTaskDetails.Columns.Add("Details", 380);
            // 
            // btnAddTask
            // 
            this.btnAddTask.BorderRadius = 15;
            this.btnAddTask.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddTask.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.Location = new System.Drawing.Point(30, 450);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(100, 30);
            this.btnAddTask.TabIndex = 5;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnTaskLists
            // 
            this.btnTaskLists.BorderRadius = 15;
            this.btnTaskLists.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaskLists.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaskLists.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaskLists.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaskLists.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTaskLists.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnTaskLists.ForeColor = System.Drawing.Color.White;
            this.btnTaskLists.Location = new System.Drawing.Point(136, 450);
            this.btnTaskLists.Name = "btnTaskLists";
            this.btnTaskLists.Size = new System.Drawing.Size(100, 30);
            this.btnTaskLists.TabIndex = 6;
            this.btnTaskLists.Text = "Task Lists";
            this.btnTaskLists.Click += new System.EventHandler(this.btnTaskLists_Click);
            // 
            // Task
            // 
            this.Task.Text = "Task";
            this.Task.Width = 150;
            // 
            // Details
            // 
            this.Details.Text = "Details";
            this.Details.Width = 380;
            // 
            // btnLogout
            // 
            this.btnLogout.BorderRadius = 15;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(242, 450);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 30);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // exitMainButton
            // 
            this.exitMainButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitMainButton.FillColor = System.Drawing.Color.Transparent;
            this.exitMainButton.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitMainButton.IconColor = System.Drawing.Color.Red;
            this.exitMainButton.Location = new System.Drawing.Point(847, 3);
            this.exitMainButton.Name = "exitMainButton";
            this.exitMainButton.Size = new System.Drawing.Size(30, 30);
            this.exitMainButton.TabIndex = 8;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(880, 510);
            this.Controls.Add(this.exitMainButton);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnTaskLists);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.lvTaskSummary);
            this.Controls.Add(this.lvTaskDetails);
            this.Name = "MainForm";
            this.Text = "Task Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvTaskSummary;
        private System.Windows.Forms.ListView lvTaskDetails;
        private Guna.UI2.WinForms.Guna2Button btnAddTask;
        private Guna.UI2.WinForms.Guna2Button btnTaskLists;
        private ColumnHeader Task;
        private ColumnHeader Details;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2ControlBox exitMainButton;
    }
}
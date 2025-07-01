using System.Windows.Forms;

namespace TaskManagementApp
{
    public partial class MainForm : Form
    {
        private System.ComponentModel.IContainer components = null;

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
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnTaskLists = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
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
            this.btnAddTask.Location = new System.Drawing.Point(30, 450);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(100, 30);
            this.btnAddTask.TabIndex = 2;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnTaskLists
            // 
            this.btnTaskLists.Location = new System.Drawing.Point(140, 450);
            this.btnTaskLists.Name = "btnTaskLists";
            this.btnTaskLists.Size = new System.Drawing.Size(100, 30);
            this.btnTaskLists.TabIndex = 3;
            this.btnTaskLists.Text = "Task Lists";
            this.btnTaskLists.UseVisualStyleBackColor = true;
            this.btnTaskLists.Click += new System.EventHandler(this.btnTaskLists_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(250, 450);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 30);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(880, 510);
            this.Controls.Add(this.lvTaskSummary);
            this.Controls.Add(this.lvTaskDetails);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.btnTaskLists);
            this.Controls.Add(this.btnLogout);
            this.Name = "MainForm";
            this.Text = "Task Manager";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListView lvTaskSummary;
        private System.Windows.Forms.ListView lvTaskDetails;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnTaskLists;
        private System.Windows.Forms.Button btnLogout;
    }
}
using System.Windows.Forms;

namespace TaskManagementApp
{
    partial class TaskListForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lvTaskLists = new System.Windows.Forms.ListView();
            this.btnAddList = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvTaskLists
            // 
            this.lvTaskLists.FullRowSelect = true;
            this.lvTaskLists.HideSelection = false;
            this.lvTaskLists.Location = new System.Drawing.Point(30, 30);
            this.lvTaskLists.Name = "lvTaskLists";
            this.lvTaskLists.Size = new System.Drawing.Size(500, 350);
            this.lvTaskLists.TabIndex = 0;
            this.lvTaskLists.UseCompatibleStateImageBehavior = false;
            this.lvTaskLists.View = System.Windows.Forms.View.Details;
            this.lvTaskLists.DoubleClick += new System.EventHandler(this.lvTaskLists_DoubleClick);


            // Add columns
            this.lvTaskLists.Columns.Add("ID", 50);
            this.lvTaskLists.Columns.Add("Name", 200);
            this.lvTaskLists.Columns.Add("Description", 230);
            // 
            // btnAddList
            // 
            this.btnAddList.Location = new System.Drawing.Point(30, 400);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(100, 30);
            this.btnAddList.TabIndex = 1;
            this.btnAddList.Text = "Add List";
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(430, 400);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TaskListForm
            // 
            this.ClientSize = new System.Drawing.Size(580, 460);
            this.Controls.Add(this.lvTaskLists);
            this.Controls.Add(this.btnAddList);
            this.Controls.Add(this.btnClose);
            this.Name = "TaskListForm";
            this.Text = "Task Lists";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListView lvTaskLists;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.Button btnClose;
    }
}
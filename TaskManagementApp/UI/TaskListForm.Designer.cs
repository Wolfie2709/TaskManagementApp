using System.Drawing;
using System;
using System.Windows.Forms;

namespace TaskManagementApp
{
    partial class TaskListForm
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2Panel panelWrapper;
        private System.Windows.Forms.ListView lvTaskLists;
        private Guna.UI2.WinForms.Guna2Button btnAddList;
        private Guna.UI2.WinForms.Guna2Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            this.panelWrapper = new Guna.UI2.WinForms.Guna2Panel();
            this.lvTaskLists = new System.Windows.Forms.ListView();
            this.btnAddList = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();

            // 
            // panelWrapper
            // 
            panelWrapper.BackColor = System.Drawing.Color.FromArgb(45, 50, 60);
            panelWrapper.Size = new Size(540, 400);
            panelWrapper.Location = new Point(20, 20);
            panelWrapper.FillColor = System.Drawing.Color.FromArgb(55, 60, 70);
            panelWrapper.BorderRadius = 12;
            panelWrapper.ShadowDecoration.Enabled = true;
            panelWrapper.Controls.Add(lvTaskLists);

            // 
            // lvTaskLists
            // 
            lvTaskLists.Location = new Point(20, 20);
            lvTaskLists.Size = new Size(500, 350);
            lvTaskLists.View = View.Details;
            lvTaskLists.FullRowSelect = true;
            lvTaskLists.HideSelection = false;
            lvTaskLists.Columns.Add("ID", 50);
            lvTaskLists.Columns.Add("Name", 200);
            lvTaskLists.Columns.Add("Description", 230);
            lvTaskLists.DoubleClick += new EventHandler(this.lvTaskLists_DoubleClick);

            // 
            // btnAddList
            // 
            btnAddList.Text = "➕ Add List";
            btnAddList.Size = new Size(120, 40);
            btnAddList.Location = new Point(40, 430);
            btnAddList.BorderRadius = 6;
            btnAddList.FillColor = Color.FromArgb(45, 140, 240);
            btnAddList.ForeColor = Color.White;
            btnAddList.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddList.Click += new EventHandler(this.btnAddList_Click);

            // 
            // btnClose
            // 
            btnClose.Text = "❌ Close";
            btnClose.Size = new Size(120, 40);
            btnClose.Location = new Point(400, 430);
            btnClose.BorderRadius = 6;
            btnClose.FillColor = Color.FromArgb(220, 50, 60);
            btnClose.ForeColor = Color.White;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.Click += new EventHandler(this.btnClose_Click);

            // 
            // TaskListForm
            // 
            this.ClientSize = new Size(580, 500);
            this.BackColor = Color.FromArgb(35, 40, 50);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "🗂️ Select Task List";
            this.Controls.Add(panelWrapper);
            this.Controls.Add(btnAddList);
            this.Controls.Add(btnClose);
        }
    }
}
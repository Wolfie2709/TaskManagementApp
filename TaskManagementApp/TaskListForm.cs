using System;
using System.Windows.Forms;
using TaskManagementApp.Models;

namespace TaskManagementApp
{
    public partial class TaskListForm : Form
    {
        private User currentUser;

        public TaskListForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            LoadTaskLists();
        }

        private void LoadTaskLists()
        {
            // For now, just show some sample lists
            // You can implement TaskListService later
            lvTaskLists.Items.Clear();

            // Sample data
            var item1 = new ListViewItem("1");
            item1.SubItems.Add("Personal Tasks");
            item1.SubItems.Add("My personal to-do items");
            lvTaskLists.Items.Add(item1);

            var item2 = new ListViewItem("2");
            item2.SubItems.Add("Work Tasks");
            item2.SubItems.Add("Office related tasks");
            lvTaskLists.Items.Add(item2);

            var item3 = new ListViewItem("3");
            item3.SubItems.Add("Shopping List");
            item3.SubItems.Add("Items to buy");
            lvTaskLists.Items.Add(item3);
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            // You can implement AddTaskListForm later
            MessageBox.Show("Add Task List functionality coming soon!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
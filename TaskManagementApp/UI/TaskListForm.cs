using System;
using System.Windows.Forms;
using TaskManagementApp.Logic;
using TaskManagementApp.Models;

namespace TaskManagementApp
{
    public partial class TaskListForm : Form
    {
        private User currentUser;
        public TaskList SelectedTaskList { get; private set; }
        private TaskListService taskListService = new TaskListService();


        public TaskListForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            LoadTaskLists();
        }

        private void LoadTaskLists()
        {
            lvTaskLists.Items.Clear();

            var taskLists = taskListService.GetTaskListsByUser(currentUser.UserID);

            foreach (var list in taskLists)
            {
                var item = new ListViewItem(list.TaskListID.ToString());
                item.SubItems.Add(list.Name);
                item.SubItems.Add(list.Description);
                lvTaskLists.Items.Add(item);
            }
        }



        private void btnAddList_Click(object sender, EventArgs e)
        {
            var form = new AddTaskListForm(currentUser);
            if (form.ShowDialog() == DialogResult.OK && form.NewTaskList != null)
            {
                var service = new TaskListService();
                bool success = service.AddTaskList(form.NewTaskList);

                if (success)
                {
                    MessageBox.Show("Task list added successfully.");
                    LoadTaskLists(); // Refresh view
                }
                else
                {
                    MessageBox.Show("Failed to add task list.");
                }
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            if (lvTaskLists.SelectedItems.Count > 0)
            {
                var selectedItem = lvTaskLists.SelectedItems[0];
                SelectedTaskList = new TaskList
                {
                    TaskListID = int.Parse(selectedItem.SubItems[0].Text),
                    Name = selectedItem.SubItems[1].Text,
                    Description = selectedItem.SubItems[2].Text,
                    UserID = currentUser.UserID
                };

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }

            this.Close();
        }
        private void lvTaskLists_DoubleClick(object sender, EventArgs e)
        {
            if (lvTaskLists.SelectedItems.Count > 0)
            {
                var selectedItem = lvTaskLists.SelectedItems[0];

                SelectedTaskList = new TaskList
                {
                    TaskListID = int.Parse(selectedItem.SubItems[0].Text),
                    Name = selectedItem.SubItems[1].Text,
                    Description = selectedItem.SubItems[2].Text,
                    UserID = currentUser.UserID
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


    }
}
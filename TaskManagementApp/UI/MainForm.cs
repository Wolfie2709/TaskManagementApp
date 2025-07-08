using System;
using System.Linq;
using System.Windows.Forms;
using AppTask = TaskManagementApp.Models.Task;
using TaskManagementApp.Models;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskManagementApp
{
    public partial class MainForm : Form
    {
        private User currentUser;
        private TaskService taskService = new TaskService();
        private Timer deadlineTimer;
        private TaskList selectedTaskList;

        public MainForm(User user)
        {
            InitializeComponent();
            currentUser = user;
            lblWelcome.Text = $"Welcome, {currentUser.FullName}";

            // Populate dropdowns safely
            if (priorityBox.Items.Count == 0)
                priorityBox.Items.AddRange(new[] { "All", "High", "Medium", "Low" });
            priorityBox.ValueMember = "Priority";

            if (statusBox.Items.Count == 0)
                statusBox.Items.AddRange(new[] { "All", "To Do", "In progress", "Done" });

            priorityBox.SelectedIndex = 0;
            statusBox.SelectedIndex = 0;

            if (selectedTaskList != null)
            {
                LoadTaskSummaries(selectedTaskList.TaskListID);
            }
            else
            {
                MessageBox.Show("Please select a task list first.", "No Task List Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Wire up filter controls
            taskNameBox.TextChanged += FilterTasks;
            priorityBox.SelectedIndexChanged += FilterTasks;
            statusBox.SelectedIndexChanged += FilterTasks;
            datePicker.ValueChanged += FilterTasks;
            btnSearch.Click += FilterTasks;
            btnReset.Click += ResetFilters;

            SetupDeadlineTimer();
            btnAddList.Click += (s, e) =>
            {
                var taskListForm = new TaskListForm(currentUser);
                if (taskListForm.ShowDialog() == DialogResult.OK)
                {
                    selectedTaskList = taskListForm.SelectedTaskList;
                    LoadTaskSummaries(selectedTaskList.TaskListID); 
                }
            };
        }

        private void SetupDeadlineTimer()
        {
            deadlineTimer = new Timer();
            deadlineTimer.Interval = 300000; // check every 30 sec
            deadlineTimer.Tick += DeadlineTimer_Tick;
            deadlineTimer.Start();
        }

        private void DeadlineTimer_Tick(object sender, EventArgs e)
        {
            var now = DateTime.Now;
            var tasks = taskService.GetTasksByUser(currentUser.UserID);

            foreach (var task in tasks)
            {
                if (task.DueDate.HasValue &&
                    !task.HasNotified &&
                    task.DueDate.Value <= now)
                {
                    ShowTaskNotification(task);
                    task.HasNotified = true;
                }
            }
        }

        private void ShowTaskNotification(AppTask task)
        {
            MessageBox.Show($"⏰ Task deadline reached!\n\n{task.Title}",
                            "Deadline Alert",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
        }

        private void LoadTaskSummaries(int taskListID)
        {
            var tasks = taskService.GetTasksByUserAndTaskList(currentUser.UserID, taskListID);
            lvTaskSummary.Items.Clear();

            foreach (var task in tasks)
            {
                var item = new ListViewItem(task.TaskID.ToString());
                item.SubItems.Add(task.Title);
                item.Tag = task;
                lvTaskSummary.Items.Add(item);
            }
        }

        private void RenderTasks(List<AppTask> tasks)
        {
            lvTaskSummary.Items.Clear();

            foreach (var task in tasks)
            {
                var item = new ListViewItem(task.TaskID.ToString());
                item.SubItems.Add(task.Title);
                item.Tag = task;
                lvTaskSummary.Items.Add(item);
            }

            // Highlight dates in calendar
            var boldDates = tasks
                .Where(t => t.DueDate.HasValue)
                .Select(t => t.DueDate.Value.Date)
                .Distinct()
                .ToArray();

            monthCalendar.BoldedDates = boldDates;
        }

        private void lvTaskSummary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTaskSummary.SelectedItems.Count == 0) return;

            var selectedItem = lvTaskSummary.SelectedItems[0];
            var task = selectedItem.Tag as AppTask;

            if (task == null)
            {
                MessageBox.Show("Could not retrieve task data.");
                return;
            }

            lvTaskDetails.Items.Clear();
            lvTaskDetails.Items.Add(new ListViewItem(new[] { "Title", task.Title }));
            lvTaskDetails.Items.Add(new ListViewItem(new[] { "Description", task.Description }));
            lvTaskDetails.Items.Add(new ListViewItem(new[] { "Status", task.Status }));
            lvTaskDetails.Items.Add(new ListViewItem(new[] { "Due Date", task.DueDate?.ToString("g") ?? "N/A" }));
            lvTaskDetails.Items.Add(new ListViewItem(new[] { "Priority", task.Priority }));
            lvTaskDetails.Items.Add(new ListViewItem(new[] { "Category", task.Category?.Name ?? "N/A" }));
        }

        private void FilterTasks(object sender, EventArgs e)
        {
            if (selectedTaskList == null)
            {
                MessageBox.Show("Please select a task list.", "No Task List Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var tasks = taskService.GetTasksByUserAndTaskList(currentUser.UserID, selectedTaskList.TaskListID);

            string keyword = string.IsNullOrWhiteSpace(taskNameBox.Text)
                ? null
                : taskNameBox.Text.Trim().ToLower();

            string selectedPriority = priorityBox.SelectedItem?.ToString();
            string selectedStatus = statusBox.SelectedItem?.ToString();

            bool usePriority = !string.IsNullOrEmpty(selectedPriority) && selectedPriority != "All";
            bool useStatus = !string.IsNullOrEmpty(selectedStatus) && selectedStatus != "All";
            bool useKeyword = !string.IsNullOrEmpty(keyword);
            bool useDateFilter = chkEnableDateFilter.Checked;
            DateTime selectedDate = datePicker.Value.Date;

            var filtered = tasks.Where(t =>
                (!useKeyword || t.Title?.ToLower().Contains(keyword) == true) &&
                (!usePriority || string.Equals(t.Priority?.Trim(), selectedPriority.Trim(), StringComparison.OrdinalIgnoreCase)) &&
                (!useStatus || string.Equals(t.Status?.Trim(), selectedStatus.Trim(), StringComparison.OrdinalIgnoreCase)) &&
                (!useDateFilter || t.DueDate.HasValue && t.DueDate.Value.Date == selectedDate)
            ).ToList();

            RenderTasks(filtered);
        }



        private void ResetFilters(object sender, EventArgs e)
        {
            taskNameBox.Text = "";

            if (priorityBox.Items.Count > 0) priorityBox.SelectedIndex = 0;
            if (statusBox.Items.Count > 0) statusBox.SelectedIndex = 0;

            datePicker.Value = DateTime.Today;
            datePicker.Text = ""; // Clear manually if needed

            if (selectedTaskList == null)
            {
                MessageBox.Show("Please select a task list first.", "No Task List Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var tasks = taskService.GetTasksByUserAndTaskList(currentUser.UserID, selectedTaskList.TaskListID);
            RenderTasks(tasks);
        }


        private void btnTaskLists_Click(object sender, EventArgs e)
        {
            var taskListForm = new TaskListForm(currentUser);
            if (taskListForm.ShowDialog() == DialogResult.OK && taskListForm.SelectedTaskList != null)
            {
                selectedTaskList = taskListForm.SelectedTaskList;
                LoadTaskSummaries(selectedTaskList.TaskListID);
                lblListName.Text = $"📋 List: {selectedTaskList.Name}";

                var tasks = taskService.GetTasksByUserAndTaskList(currentUser.UserID, selectedTaskList.TaskListID);
                HighlightTaskDates(tasks);
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (selectedTaskList == null)
            {
                MessageBox.Show("Please choose a task list before adding a task.", "No Task List Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var addForm = new AddTask(currentUser, selectedTaskList);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadTaskSummaries(selectedTaskList.TaskListID); // Refresh view
            }
        }
        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (lvTaskSummary.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a task to edit.", "No Task Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedTaskList == null)
            {
                MessageBox.Show("Please choose a task list first.", "No Task List Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedItem = lvTaskSummary.SelectedItems[0];
            var selectedTask = selectedItem.Tag as Task;

            if (selectedTask != null)
            {
                var editForm = new AddTask(currentUser, selectedTaskList, selectedTask);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadTaskSummaries(selectedTaskList.TaskListID);
                }
            }
        }
        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (selectedTaskList == null)
            {
                MessageBox.Show("Please select a task list first.", "No Task List Selected");
                return;
            }

            var selectedDate = e.Start.Date;
            var allTasks = taskService.GetTasksByUserAndTaskList(currentUser.UserID, selectedTaskList.TaskListID);
            var filteredTasks = allTasks.Where(t => t.DueDate.HasValue && t.DueDate.Value.Date == selectedDate).ToList();

            lvTaskSummary.Items.Clear();

            foreach (var task in filteredTasks)
            {
                var item = new ListViewItem(task.TaskID.ToString());
                item.SubItems.Add(task.Title);
                item.Tag = task;
                lvTaskSummary.Items.Add(item);
            }

            lblCurrentList.Text = $"📆 Tasks for: {selectedDate:MMMM dd, yyyy}";
        }
        private void HighlightTaskDates(List<AppTask> tasks)
        {
            var dateSet = new HashSet<DateTime>();
            foreach (var task in tasks)
            {
                if (task.DueDate.HasValue)
                    dateSet.Add(task.DueDate.Value.Date);
            }

            monthCalendar.BoldedDates = dateSet.ToArray(); 
        }

    }
}

using System.Collections.Generic;
using TaskManagementApp.DAL;
using TaskManagementApp.Models;
using AppTask = TaskManagementApp.Models.Task;

namespace TaskManagementApp
{
    public class TaskService
    {
        private TaskDAL taskDAL = new TaskDAL();

        public List<AppTask> GetTasksByUser(int userId)
        {
            return taskDAL.GetTasksByUser(userId);
        }

        // Add this method that AddTask.cs is calling
        public bool AddTask(AppTask task)
        {
            return taskDAL.InsertTask(task);
        }

        public bool InsertTask(AppTask task)
        {
            return taskDAL.InsertTask(task);
        }
    }
}
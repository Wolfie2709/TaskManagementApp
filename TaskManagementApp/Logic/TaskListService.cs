using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementApp.Models;
using TaskManagementApp.DataAccess;


namespace TaskManagementApp.Logic
{
    public class TaskListService
    {
        private TaskListDAL dal = new TaskListDAL();

        public List<TaskList> GetTaskListsByUser(int userId)
        {
            return dal.GetTaskListsByUser(userId);
        }

        public bool AddTaskList(TaskList list)
        {
            return new TaskListDAL().InsertTaskList(list);
        }

    }
}
    


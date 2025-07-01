using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementApp.DataAccess
{
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using TaskManagementApp.Models;
    using TaskManagementApp.DataAccess;

    public class TaskListDAL
    {
        public List<TaskList> GetTaskListsByUser(int userId)
        {
            var taskLists = new List<TaskList>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM TaskLists WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        taskLists.Add(new TaskList
                        {
                            TaskListID = (int)reader["TaskListID"],
                            Name = reader["Name"].ToString(),
                            Description = reader["Description"].ToString(),
                            UserID = (int)reader["UserID"]
                        });
                    }
                }
            }

            return taskLists;
        }
        public bool InsertTaskList(TaskList list)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                string query = @"INSERT INTO TaskLists (Name, Description, UserID, CreatedAt, UpdatedAt)
                         VALUES (@Name, @Description, @UserID, @CreatedAt, @UpdatedAt)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", list.Name);
                cmd.Parameters.AddWithValue("@Description", list.Description);
                cmd.Parameters.AddWithValue("@UserID", list.UserID);
                cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                cmd.Parameters.AddWithValue("@UpdatedAt", DateTime.Now);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

    }

}

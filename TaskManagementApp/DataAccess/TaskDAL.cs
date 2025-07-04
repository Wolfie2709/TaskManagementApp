using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using TaskManagementApp.Models;
using AppTask = TaskManagementApp.Models.Task;
using TaskManagementApp.DataAccess;

namespace TaskManagementApp.DAL
{
    public class TaskDAL
    {
        private readonly string connectionString = DatabaseHelper.GetConnection().ConnectionString;

        public List<AppTask> GetTasksByUser(int userId)
        {
            List<AppTask> tasks = new List<AppTask>();

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Tasks WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tasks.Add(new AppTask
                        {
                            TaskID = (int)reader["TaskID"],
                            UserID = (int)reader["UserID"],
                            CategoryID = reader["CategoryID"] == DBNull.Value ? null : (int?)reader["CategoryID"],
                            Title = reader["Title"].ToString(),
                            Description = reader["Description"].ToString(),
                            Status = reader["Status"].ToString(),
                            DueDate = reader["DueDate"] == DBNull.Value ? null : (DateTime?)reader["DueDate"],
                            Priority = reader["Priority"].ToString(),
                            CreatedAt = (DateTime)reader["CreatedAt"]
                        });
                    }
                }
            }

            return tasks;
        }
        public bool InsertTask(AppTask task)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"INSERT INTO Tasks (UserID, Title, Description, Status, DueDate, Priority, TaskListID)
VALUES (@UserID, @Title, @Description, @Status, @DueDate, @Priority, @TaskListID)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", task.UserID);
                cmd.Parameters.AddWithValue("@Title", task.Title);
                cmd.Parameters.AddWithValue("@Description", task.Description);
                cmd.Parameters.AddWithValue("@Status", task.Status);
                cmd.Parameters.AddWithValue("@DueDate", (object)task.DueDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Priority", task.Priority);
                cmd.Parameters.AddWithValue("@TaskListID", task.TaskListID);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public List<AppTask> GetTasksByUserAndTaskList(int userId, int taskListId)
        {
            var tasks = new List<AppTask>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Tasks WHERE UserID = @UserID AND TaskListID = @TaskListID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@TaskListID", taskListId);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tasks.Add(new AppTask
                        {
                            TaskID = (int)reader["TaskID"],
                            UserID = (int)reader["UserID"],
                            Title = reader["Title"].ToString(),
                            Description = reader["Description"].ToString(),
                            Status = reader["Status"].ToString(),
                            Priority = reader["Priority"].ToString(),
                            DueDate = reader["DueDate"] as DateTime?,
                            CreatedAt = (DateTime)reader["CreatedAt"],
                            // Add this if your model includes TaskListID
                            TaskListID = reader["TaskListID"] as int?
                        });
                    }
                }
            }

            return tasks;
        }

        public bool UpdateTask(AppTask task)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"UPDATE Tasks SET 
                            Title = @Title,
                            Description = @Description,
                            Status = @Status,
                            DueDate = @DueDate,
                            Priority = @Priority
                         WHERE TaskID = @TaskID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Title", task.Title);
                cmd.Parameters.AddWithValue("@Description", task.Description);
                cmd.Parameters.AddWithValue("@Status", task.Status);
                cmd.Parameters.AddWithValue("@DueDate", (object)task.DueDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Priority", task.Priority);
                cmd.Parameters.AddWithValue("@TaskID", task.TaskID);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public bool DeleteTask(int taskId)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Tasks WHERE TaskID = @TaskID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TaskID", taskId);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // Optional: AddTask, UpdateTask, DeleteTask methods later
    }
}

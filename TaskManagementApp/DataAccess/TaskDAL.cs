using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            var tasks = new List<AppTask>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT t.*, c.Name AS CategoryName
                    FROM Tasks t
                    LEFT JOIN Categories c ON t.CategoryID = c.CategoryID
                    WHERE t.UserID = @UserID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);

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
                            DueDate = reader["DueDate"] == DBNull.Value ? null : (DateTime?)reader["DueDate"],
                            Priority = reader["Priority"].ToString(),
                            CreatedAt = (DateTime)reader["CreatedAt"],
                            TaskListID = reader["TaskListID"] == DBNull.Value ? null : (int?)reader["TaskListID"],
                            CategoryID = reader["CategoryID"] == DBNull.Value ? null : (int?)reader["CategoryID"],
                            Category = new Category
                            {
                                CategoryID = reader["CategoryID"] == DBNull.Value ? 0 : (int)reader["CategoryID"],
                                Name = reader["CategoryName"]?.ToString()
                            }
                        });
                    }
                }
            }

            return tasks;
        }

        public List<AppTask> GetTasksByUserAndTaskList(int userId, int taskListId)
        {
            var tasks = new List<AppTask>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT t.*, c.Name AS CategoryName
                    FROM Tasks t
                    LEFT JOIN Categories c ON t.CategoryID = c.CategoryID
                    WHERE t.UserID = @UserID AND t.TaskListID = @TaskListID";

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
                            DueDate = reader["DueDate"] == DBNull.Value ? null : (DateTime?)reader["DueDate"],
                            CreatedAt = (DateTime)reader["CreatedAt"],
                            TaskListID = reader["TaskListID"] == DBNull.Value ? null : (int?)reader["TaskListID"],
                            CategoryID = reader["CategoryID"] == DBNull.Value ? null : (int?)reader["CategoryID"],
                            Category = new Category
                            {
                                CategoryID = reader["CategoryID"] == DBNull.Value ? 0 : (int)reader["CategoryID"],
                                Name = reader["CategoryName"]?.ToString()
                            }
                        });
                    }
                }
            }

            return tasks;
        }

        public bool InsertTask(AppTask task)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    INSERT INTO Tasks (UserID, Title, Description, Status, DueDate, Priority, TaskListID, CategoryID, CreatedAt)
                    VALUES (@UserID, @Title, @Description, @Status, @DueDate, @Priority, @TaskListID, @CategoryID, @CreatedAt)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", task.UserID);
                cmd.Parameters.AddWithValue("@Title", task.Title);
                cmd.Parameters.AddWithValue("@Description", task.Description);
                cmd.Parameters.AddWithValue("@Status", task.Status);
                cmd.Parameters.AddWithValue("@DueDate", (object)task.DueDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Priority", task.Priority);
                cmd.Parameters.AddWithValue("@TaskListID", task.TaskListID);
                cmd.Parameters.AddWithValue("@CategoryID", (object)task.CategoryID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@CreatedAt", task.CreatedAt);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateTask(AppTask task)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    UPDATE Tasks SET 
                        Title = @Title,
                        Description = @Description,
                        Status = @Status,
                        DueDate = @DueDate,
                        Priority = @Priority,
                        CategoryID = @CategoryID
                    WHERE TaskID = @TaskID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Title", task.Title);
                cmd.Parameters.AddWithValue("@Description", task.Description);
                cmd.Parameters.AddWithValue("@Status", task.Status);
                cmd.Parameters.AddWithValue("@DueDate", (object)task.DueDate ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Priority", task.Priority);
                cmd.Parameters.AddWithValue("@CategoryID", (object)task.CategoryID ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@TaskID", task.TaskID);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteTask(int taskId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Tasks WHERE TaskID = @TaskID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TaskID", taskId);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}

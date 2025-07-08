using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TaskManagementApp.Models;
using TaskManagementApp.DataAccess;

namespace TaskManagementApp.DAL
{
    public class CategoryDAL
    {
        private readonly string connectionString = DatabaseHelper.GetConnection().ConnectionString;

        public List<Category> GetCategoriesByUser(int userId)
        {
            var categories = new List<Category>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT CategoryID, Name, UserID FROM Categories WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categories.Add(new Category
                        {
                            CategoryID = (int)reader["CategoryID"],
                            Name = reader["Name"].ToString(),
                            UserID = (int)reader["UserID"]
                        });
                    }
                }
            }
            return categories;
        }

        public List<Category> GetAllCategories()
        {
            var categories = new List<Category>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT CategoryID, Name, UserID FROM Categories";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categories.Add(new Category
                        {
                            CategoryID = (int)reader["CategoryID"],
                            Name = reader["Name"].ToString(),
                            UserID = (int)reader["UserID"]
                        });
                    }
                }
            }
            return categories;
        }

        public bool InsertCategory(Category category)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Categories (Name, UserID) VALUES (@Name, @UserID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", category.Name);
                cmd.Parameters.AddWithValue("@UserID", category.UserID);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateCategory(Category category)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Categories SET Name = @Name WHERE CategoryID = @CategoryID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", category.Name);
                cmd.Parameters.AddWithValue("@CategoryID", category.CategoryID);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool DeleteCategory(int categoryId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Categories WHERE CategoryID = @CategoryID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CategoryID", categoryId);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}

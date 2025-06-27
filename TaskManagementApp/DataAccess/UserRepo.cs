using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementApp.Models;

namespace TaskManagementApp.DataAccess
{
    public class UserRepository
    {
        public User Login(string username, string password)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT * FROM Users WHERE Username = @Username AND PasswordHash = @Password", conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password); // In production, use hashing!
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new User
                    {
                        UserID = (int)reader["UserID"],
                        Username = reader["Username"].ToString(),
                        FullName = reader["FullName"].ToString()
                    };
                }
                return null;
            }
        }

        public bool Register(User user)
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("INSERT INTO Users (Username, PasswordHash, FullName) VALUES (@Username, @Password, @FullName)", conn);
                cmd.Parameters.AddWithValue("@Username", user.Username);
                cmd.Parameters.AddWithValue("@Password", user.PasswordHash);
                cmd.Parameters.AddWithValue("@FullName", user.FullName);
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementApp.DataAccess
{
    public static class DatabaseHelper
    {
        public static string ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ToDoList;Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }

}

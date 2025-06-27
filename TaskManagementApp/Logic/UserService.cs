using TaskManagementApp.DAL;
using TaskManagementApp.Models;

namespace TaskManagementApp
{
    public class UserService
    {
        private UserDAL userDAL = new UserDAL();

        // Sign up
        public bool SignUp(User user)
        {
            if (userDAL.GetUserByUsername(user.Username) != null)
                return false;

            return userDAL.InsertUser(user);
        }

        // Log in
        public User Login(string username, string password)
        {
            var user = userDAL.GetUserByUsername(username);
            if (user != null && user.PasswordHash == password) // Add hash validation later
                return user;

            return null;
        }
    }
}

using System.Collections.Generic;
using TaskManagementApp.Models;
using TaskManagementApp.DAL;

namespace TaskManagementApp.Services
{
    public class CategoryService
    {
        private readonly CategoryDAL categoryDAL = new CategoryDAL();

        public List<Category> GetCategories()
        {
            return categoryDAL.GetAllCategories();
        }

        public List<Category> GetCategoriesByUser(int userId)
        {
            return categoryDAL.GetCategoriesByUser(userId);
        }

        public bool AddCategory(Category category)
        {
            return categoryDAL.InsertCategory(category);
        }

        public bool UpdateCategory(Category category)
        {
            return categoryDAL.UpdateCategory(category);
        }

        public bool DeleteCategory(int categoryId)
        {
            return categoryDAL.DeleteCategory(categoryId);
        }
    }
}

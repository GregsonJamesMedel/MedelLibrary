using System.Collections.Generic;
using MedelLibrary.Models;

namespace MedelLibrary.Services
{
    public interface ICategory
    {
        void AddCategory(Category category);
        void DeleteCategory(int id);
        bool UpdateCategory(int id, Category category);
        Category GetCategoryById(int id);
        IEnumerable<Category> GetAllCategories();
    }
}
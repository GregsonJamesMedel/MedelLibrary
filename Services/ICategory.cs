using System.Collections.Generic;
using MedelLibrary.Models;

namespace MedelLibrary.Services
{
    public interface ICategory
    {
        void AddCategory(Category category);
        void DeleteCategory(int id);

        Category GetCategoryById(int id);
        IEnumerable<Category> GetAllCategories();
    }
}
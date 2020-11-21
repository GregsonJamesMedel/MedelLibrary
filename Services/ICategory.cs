using System.Collections.Generic;
using MedelLibrary.Models;

namespace MedelLibrary.Services
{
    public interface ICategory
    {
        void AddCategory(Category category);
        IEnumerable<Category> GetAllCategories();
    }
}
using System.Collections.Generic;
using MedelLibrary.Data;
using MedelLibrary.Models;

namespace MedelLibrary.Services
{
    public class CategoryService : ICategory
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            this._context = context;
        }

        public void AddCategory(Category category)
        {
            this._context.Categories.Add(category);
            this._context.SaveChanges();
        }

        public void DeleteCategory(int id)
        {
            var catToRemove = this._context.Categories.Find(id);
            if (catToRemove != null)
            {
                this._context.Categories.Remove(catToRemove);
                this._context.SaveChanges();
            }
            return;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return this._context.Categories;
        }
    }
}
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

        public bool AddCategory(Category category)
        {
            this._context.Categories.Add(category);
            var result = this._context.SaveChanges();
            return result > 0 ? true : false;
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

        public Category GetCategoryById(int id)
        {
            return this._context.Categories.Find(id);
        }

        public bool UpdateCategory(int id, Category category)
        {
            var categoryToUpdate = this._context.Categories.Find(id);

            categoryToUpdate.Name = category.Name;

            this._context.Update(categoryToUpdate);
            var res = this._context.SaveChanges();

            return res > 0 ? true : false;
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using ShoppingCart.DataAccess.Model;
using ShoppingCart.Service.Data;
using ShoppingCart.Service.Infrastructure;

namespace ShoppingCart.Service.Repositories
{
    public class CategoryRepo : ICategory
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.FirstOrDefault(x => x.Id == id);
        }

        public void InsertCategory(Category category)
        {
            _context.Categories.Add(category);
        }

        public void UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
        }

        public void DeleteCategory(Category category)
        {
            _context.Categories.Remove(category);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
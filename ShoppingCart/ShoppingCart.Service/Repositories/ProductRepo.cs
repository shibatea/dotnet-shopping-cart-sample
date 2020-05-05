using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ShoppingCart.DataAccess.Model;
using ShoppingCart.Service.Data;
using ShoppingCart.Service.Infrastructure;

namespace ShoppingCart.Service.Repositories
{
    public class ProductRepo : IProduct
    {
        private readonly ApplicationDbContext _context;

        public ProductRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products
                .Include(product => product.Categories)
                .ThenInclude(productCategory => productCategory.Category)
                .FirstOrDefault(product => product.Id == id);
        }

        public void InsertProduct(Product product)
        {
        }

        public void UpdateProduct(Product product)
        {
        }

        public void DeleteProduct(Product product)
        {
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
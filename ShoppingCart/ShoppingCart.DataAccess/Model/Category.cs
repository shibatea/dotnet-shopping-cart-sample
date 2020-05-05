using System.Collections;
using System.Collections.Generic;

namespace ShoppingCart.DataAccess.Model
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ProductCategory> Products { get; set; }
    }
}
using System.Collections.Generic;

namespace EFCodeFirstDemo.Models
{
    public class Category
    {
        public Category()
        {
            this.ProductList = new HashSet<Product>();
        }
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Product> ProductList{ get; set; }
    }
}
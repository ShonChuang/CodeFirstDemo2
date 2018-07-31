using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstDemo.Models
{
    public class Category
    {
        public Category()
        {
            this.ProductList = new HashSet<Product>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string CategoryName { get; set; }

        public virtual ICollection<Product> ProductList{ get; set; }
    }
}
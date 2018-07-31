using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFCodeFirstDemo.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
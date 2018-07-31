using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFCodeFirstDemo.Models
{
    public class MyDbcontext : DbContext
    {
        public MyDbcontext()
            : base("name=MyDbcontext")
        {

        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
    }
}
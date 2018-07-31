namespace EFCodeFirstDemo.Migrations
{
    using EFCodeFirstDemo.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFCodeFirstDemo.Models.MyDbcontext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EFCodeFirstDemo.Models.MyDbcontext context)
        {
            var initialCatgory = new List<Category>()
            {
                new Category{ CategoryName ="c1" },
                new Category{ CategoryName ="c2" },
                new Category{ CategoryName ="c3" }
            };
            initialCatgory.ForEach(d => context.Categories.AddOrUpdate(s => s.CategoryName, d));
            context.SaveChanges();

            var InitialProduct = new List<Product>() {
                new Product { ProductName="p1",CategoryId=1 },
                new Product { ProductName="p2",CategoryId=2 },
                new Product { ProductName="p3",CategoryId=1 }
            };
            InitialProduct.ForEach(p => context.Products.AddOrUpdate(s => s.ProductName, p));
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}

namespace CF_Exam_7.Migrations
{
    using CF_Exam_7.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CF_Exam_7.DAL.OrderContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(CF_Exam_7.DAL.OrderContext context)
        {
            var category = new List<Category>
            {
                new Category{CategoryName="125cc"},
                new Category{CategoryName="160cc"}
            };
            category.ForEach(s=>context.Categories.AddOrUpdate(p=>p.CategoryName,s));
            context.SaveChanges();


            var product = new List<Product>
            {
                new Product{CategoryID=1, ProductName="Stryker"},
                new Product{CategoryID=1, ProductName="Sp_Shine"},

                new Product{CategoryID=2, ProductName="MT-15" },
                new Product{CategoryID=2, ProductName="X-Blade"}
            };
            product.ForEach(s=>context.Products.AddOrUpdate(p=>p.ProductName,s));
            context.SaveChanges();
        }
    }
}

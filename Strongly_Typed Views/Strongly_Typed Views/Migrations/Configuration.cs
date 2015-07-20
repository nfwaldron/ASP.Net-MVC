namespace Strongly_Typed_Views.Migrations
{
    using Strongly_Typed_Views.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Strongly_Typed_Views.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Strongly_Typed_Views.Models.DataContext context)
        {
            
            // You must use an array here.
            var products = new Product[]
            {
                new Product{Name="Water", Price = 3.50m, Description="From the islands of Fiji. Natural artesian water"},
                new Product{Name="Bread", Price = 4.50m, Description="Baked in the brick ovens of Italy!"},
                new Product{Name="Wine", Price=150.00m, Description="Fermented for over 100 years in the doldrums of Castle Linq"}
            };

            context.Product.AddOrUpdate(p => p.Name, products);
            
            
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}

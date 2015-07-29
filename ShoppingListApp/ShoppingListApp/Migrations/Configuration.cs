namespace ShoppingListApp.Migrations
{
    using ShoppingListApp.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ShoppingListApp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ShoppingListApp.Models.ApplicationDbContext context)
        {

            var shoppingList1 = new List<Product>()
            {
                new Product{ Cost = 23.50m, ItemName = "Shirt"},
                new Product{ Cost = 12.45m, ItemName = "Underwear"},
                new Product { Cost = 2.30m, ItemName = "Socks"}
            };

            var shoppingList2 = new List<Product>()
            {
                new Product{ Cost = 13.50m, ItemName = "Bras"},
                new Product{ Cost = 22.45m, ItemName = "Lipstick"},
                new Product { Cost = 12.30m, ItemName = "Perfume"}
            };
            
            var customers = new Customer[]
            {
                new Customer{FirstName = "Nathan", 
                             LastName = "Waldron",
                             ProductList = shoppingList1
                             },

                new Customer{FirstName = "Maxine",
                             LastName = "Waldron",
                             ProductList = shoppingList2
                             }
            };


        }
    }
}

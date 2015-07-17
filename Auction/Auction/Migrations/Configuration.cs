namespace Auction.Migrations
{
    using Auction.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Auction.Models.ItemDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Auction.Models.ItemDataContext context)
        {
            var items = new Item[]
            {
                new Item {Name="Tesla", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit!", MinimumBid = 70000m},
                new Item {Name="Le Fay Bass", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit", MinimumBid = 4700m},
                new Item {Name="Macbook Pro", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit", MinimumBid = 1590m}
            };

            context.Item.AddOrUpdate(model => model.Id, items);
            
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

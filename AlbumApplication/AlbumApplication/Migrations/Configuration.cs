namespace AlbumApplication.Migrations
{
    using AlbumApplication.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AlbumApplication.Models.AlbumDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AlbumApplication.Models.AlbumDB context)
        {
            var albums = new Album[]
            {
                new Album {Title = "Covered", Artist = "Robert Glasper", Genre = "Jazz"},
                new Album {Title = "One", Artist = "The Beetles", Genre = "Classic Rock"},
                new Album {Title = "Blame it on the Streets", Artist = "Neighborhood", Genre = "Rock"}
            };

            context.Albums.AddOrUpdate(a => a.Title, albums);

            
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
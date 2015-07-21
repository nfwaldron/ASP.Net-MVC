namespace AlbumApplication.Migrations
{
    using AlbumApplication.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AlbumApplication.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AlbumApplication.Models.DataContext context)
        {
            var albums = new Album[]
            {
                new Album {Title = "Covered", Artist = "Robert Glasper", Genre = "Jazz"},
                new Album {Title = "One", Artist = "The Beetles", Genre = "Classic Rock"},
                new Album {Title = "Blame it on the Streets", Artist = "Neighborhood", Genre = "Rock"}
            };

            context.Albums.AddOrUpdate(a => a.Title, albums);

        }
    }
}

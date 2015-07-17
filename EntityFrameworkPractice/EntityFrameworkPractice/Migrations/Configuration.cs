namespace EntityFrameworkPractice.Migrations
{
    using EntityFrameworkPractice.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFrameworkPractice.Models.MoviesDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EntityFrameworkPractice.Models.MoviesDB";
        }

        protected override void Seed(EntityFrameworkPractice.Models.MoviesDB context)
        {
            //In the CONFIGURATION FILE, YOU MUST USE AN ARRAY. YOU CANNOT USE A LIST

            var categories = new Category[]
            {
                new Category{
                    Name = "Science Fiction",
                    Movies = new List<Movie> {
                        new Movie {Title = "Star Wars"},
                        new Movie {Title = "Blade Runner"}
                    }
                },

                
                new Category{
                    Name = "Drama",
                    Movies = new List<Movie> {
                        new Movie {Title = "Momento"},
                        new Movie {Title = "Ex Machina"}
                    }
                },
            
            
            };

            context.Categories.AddOrUpdate(c => c.Name, categories);
            
            
            /*
            //create array of movies
            var movies = new Movie[]
            {
                new Movie{Title = "Star Wars", Director = "Lucas" },
                new Movie{Title = "Terminator", Director = "Smith"},
                new Movie{Title = "Batman vs Superman", Director = "Snyder"}
            };

            // Ill be running seed method over, and over again, without adding duplicat movies
            // I dont want to add the same moveis to the database when I update the database
            // The AddOrUpdate method acts as a means to look at a property of the movies object
            // of the Movie class, and so long as the title remains the same, don't update/re-add to database

            context.Movies.AddOrUpdate(m => m.Title, movies);
            */ 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameworkPractice.Models
{
    public class MoviesDB: DbContext // DbContext class is needed to set up Entity framework 
    {
        public MoviesDB()
        {
            // In constructor...DISABLE LAZY LOADING
            this.Configuration.LazyLoadingEnabled = false;

            // Database initialization strategy.
            // Allows for update when things become out of sync.
            // DropCreateDatabaseAlways(<MoviesDB>) will create a new movie database and update the database whenever
            // model classes change.
            // Database.SetInitializer(new DropCreateDatabaseAlways<MoviesDB>());

            // Migrations allows you to seed database with default information.
            // Furthermore, when you update your models, Migrations allow you to incrementally
            // Update the database to synchronize models and what is stored in the database.
            //
            // Enable-Migrations -ContextTypeName "Name of ClassDB"
            //
            // Type Enable-Migrations -ContextTypeName MoviesDB
            //

        }

        // Your database has a property Movies and Catagories
        public IDbSet<Movie> Movies { get; set; }
        public IDbSet<Category> Categories { get; set; }


    }
}
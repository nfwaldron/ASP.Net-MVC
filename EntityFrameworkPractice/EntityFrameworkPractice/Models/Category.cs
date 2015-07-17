using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkPractice.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // This creates a navigation property so that we can associate between categories and movies.
        // You have to use the virtual method.
        // This is called lazy loading. Until you begin to iterate through the items in your the class will
        // not load the list of movies.
        // NEVER USE THIS
        // public virtual ICollection<Movie> Movies { get; set; }
        public ICollection<Movie> Movies { get; set; }

    }
}
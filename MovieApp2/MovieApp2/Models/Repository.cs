using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieApp2.Models
{
    // Create a Class named repository
    public class Repository
    {
        // Program against abstractions, return an interface List of movies
        // Inside the class method
        public IList<Movie> ListMovies()
        {
            return new List<Movie>
            {
                new Movie { MovieTitle = "Star Wars", MovieDirector = "George Lucas"},
                new Movie { MovieTitle = "Momento", MovieDirector = "Christopher Nolan"},
                new Movie { MovieTitle = "Terminator", MovieDirector = "James Cameron"}
            };

        }
    }
}
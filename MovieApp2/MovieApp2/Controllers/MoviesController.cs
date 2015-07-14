using MovieApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieApp2.Controllers
{
    public class MoviesController : Controller
    {
        //Create instance of movie repository
        private Repository _repo = new Repository();

        // GET: Movies
        public ActionResult Index()
        {
            var movies = _repo.ListMovies();
            return View(movies);
        }

        [Route("ShowMovieDetails/{director:alpha}")]
        public ActionResult Details(string director)
        {
            return Content("Details for " + director);
        }
    }
}
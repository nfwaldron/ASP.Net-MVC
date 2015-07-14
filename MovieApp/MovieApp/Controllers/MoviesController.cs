using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class MoviesController : Controller
    {
        private Repository _repo = new Repository();

        // GET: Movies
        public ActionResult Index()
        {
            var movies = _repo.ListMovies();
            return View(movies);
        }
    }
}
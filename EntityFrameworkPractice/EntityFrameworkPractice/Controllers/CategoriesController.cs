using EntityFrameworkPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace EntityFrameworkPractice.Controllers
{
    public class CategoriesController : Controller
    {
        private MoviesDB _db = new MoviesDB();

        // GET: Categories
        public ActionResult Index()
        {
            // Be sure to use .Include() to enable eager loading to enable association between all
            // database entities.
            // If I had to include more properties of the var categories = _db.Categories.Include(c=> c.Movies).Include(c=> c.Tags)ToList()
            var categories = _db.Categories.Include(c=> c.Movies).ToList();
            return View(categories);
        }

    }
}
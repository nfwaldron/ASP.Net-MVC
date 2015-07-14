using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieApp2.Controllers
{
    public class BlogsController : Controller
    {
        // GET: Blogs
        public ActionResult GetEntryByDate( DateTime entryDate)
        {

            return Content("You requested the blog post from " + entryDate.ToLongDateString());
        }

        public ActionResult GetEntryById(int entryId)
        {

            return Content("You requested the blog post from " + entryId.ToString());
        }
    }
}
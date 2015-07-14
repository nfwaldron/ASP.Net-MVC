using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieApp2.Controllers
{
    public class ProductsController : Controller // Controller is a class that inherits from base controller class.
    {
        // GET: Products
        // 
        public ActionResult Index()
        {

            return View();
        }
    }
}
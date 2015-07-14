using RazorPractice.Models;
using RazorPractice.Views.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorPractice.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var products = new List<Product>()
            {
                new Product{Id = "product1", Name = "Milk", Price = 3.59m, OnSale = true},
                new Product{Id = "product2", Name = "Bread", Price = 2.49m, OnSale = false},
                new Product{Id = "product3", Name = "Cheese", Price = 4.09m, OnSale = true},
            };

            // View Data is essentially a dictionary. This gives me a way to pass objects from the controller to the view.
            // I can go to my view and insert ViewData["product"] in the 'Home' view.
            // This is a weakly typed viewing method. NEVER USE VIEWDATA!!!!!!
            // ViewData["product"] = products;


            // IndexVM is view model. 
            var vm = new IndexVM
            {
                // Assign to the Products property of the IndexVM Class the List of Products 
                Products = products
            };

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
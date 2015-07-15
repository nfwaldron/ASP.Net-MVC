using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using UserRegistration.Models;

namespace UserRegistration.Controllers
{
    public class UsersController : Controller
    {
        // In order to properly utilize the remote method for checking a database...
        public ActionResult ValidateUsername(string username)
        {
            if (username=="nfwaldron")
            {
                return Json(false);
            }

            else
	        {
                return Json(true);
	        }
        }

        // GET: Users
        public ActionResult Index()
        {
            return View();
        }

        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        // Utilize the ModelState class in order to complete form validation. 
        [HttpPost]
        public ActionResult Create(User user)
        {
            // Regex pattern for social security numbers
            var socialPattern = @"^\d{3}-\d{2}-\d{4}$";

            var comments = user.Comments.ToCharArray();


            if (user.Password != user.ConfirmPassword)
            {
                ModelState.AddModelError("ConfirmPassword", "Passwords to not match!");
            }

            if (Regex.IsMatch(user.SocialSecurityNumber,socialPattern) == false)
            {
                ModelState.AddModelError("SocialSecurityNumber", "Please enter social security number with dashes");
            }

            if (comments.Length > 50)
            {
                
            }

            else
            {
                return View();
            }

               
            
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Users/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Users/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace Security.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // You cannot access this page unless you are a logged in administrator
        // If users are not logged in, they will be forced to register.
        
        [Authorize(Roles="Admin")]
        public ActionResult About()
        {
            // Only people who have the canEditProducts claim have the right to invoke this controller
            var user = this.User as ClaimsPrincipal;
            if (user.HasClaim("CanEditProducts","true")== false)
            {
                return new HttpUnauthorizedResult("You don't have the rights!");
            }
            

            //// check if user is admin
            //if (User.IsInRole("Admin"))
            //{
            //    ViewBag.IsAdmin = true;
            //}

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
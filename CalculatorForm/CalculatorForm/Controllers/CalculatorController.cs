using CalculatorForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculatorForm.Controllers
{
    public class CalculatorController : Controller
    {
        // POST: Calculator
        // Storing all of the model bound information captured from the user in the properties of the class Calculator 
     
        [HttpPost] // Allows browser to know that you are making a POST request.
        public ActionResult Index(Calculator calculatorVM) // Parameter Calculator is data type, calculatorVM is the name
        {

            calculatorVM.Result = calculatorVM.Number1 + calculatorVM.Number2; 
        
           return View(calculatorVM);
        }

        // GET: Calculator
        // Browser user enter a request for a webpage...
        // GET methods retrieve the page from the web server...on which  this program that I'm creating is stored.

        public ActionResult Index()
        {
            return View();
        }

        // GET: Calculator/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Calculator/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Calculator/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Calculator/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Calculator/Edit/5
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

        // GET: Calculator/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Calculator/Delete/5
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

using CalculatorForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculatorForm.Controllers
{
    public class CalculatorsController : Controller
    {
        // GET: Calculators
        public ActionResult Index()
        {
            return View();
        }

        // POST: Calculator
        // The ActionResult class represents the result of an action method.

        public ActionResult Index(Calculator calculatorVM )
        {
            calculatorVM.Result = calculatorVM.Number1 + calculatorVM.Number2;

            // The view object renders a view to the response.
            // Return the updated object of the View Model class to the view.
            // In the view, the @model reference will allow you to
            return View(calculatorVM);
        }

        // GET: Calculators/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Calculators/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Calculators/Create
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

        // GET: Calculators/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Calculators/Edit/5
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

        // GET: Calculators/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Calculators/Delete/5
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

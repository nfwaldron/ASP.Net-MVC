using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserRegistration.Controllers
{
    public class BannerAdsController : Controller
    {
        
        // GET: BannerAds
        // not meant to be invoked from internet, only meant to be invoked by the view
        [ChildActionOnly]
        public ActionResult GetAd()
        {
            var adText = "Buy Coffee!";

            if (DateTime.Now.Hour>20)
            {
                adText = "Buy Tea!";
            }


            return PartialView("_Ad", adText);

        }


        public ActionResult Index()
        {
            return View();
        }

        // GET: BannerAds/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BannerAds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BannerAds/Create
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

        // GET: BannerAds/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BannerAds/Edit/5
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

        // GET: BannerAds/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BannerAds/Delete/5
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

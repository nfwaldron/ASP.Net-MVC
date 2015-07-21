using AlbumApplication.Models;
using AlbumApplication.Services;
using CoderCamps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlbumApplication.Controllers
{
    public class AlbumsController : Controller
    {
        private IAlbumService _service;
        
        // formerly IRepository
        public AlbumsController(IAlbumService service)
        {
            _service = service;
        }
          
        // GET: Albums
        public ActionResult Index()
        {

            // For more complicated requests
            // var albums = (from a in _repo.Query<Album>() select a).ToList();

           // var albums = _repo.Query<Album>.ToList();

            //var albums = _db.Albums.ToList();
            //var albums = (from a in _db.Albums select a).ToList();
            return View(_service.List());
        }

        // GET: Albums/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Albums/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Albums/Create
        [HttpPost]
        public ActionResult Create(Album album)
        {
            if (ModelState.IsValid)
            {
                _service.Create(album);
                return RedirectToAction("Index");
            }

            return View();
        }

        // GET: Albums/Edit/5
        // You can ensure that you get sent to edit without passing values.
        // Make id nullable, so that if it doesn't exist the user gets redirected to "Index"
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            // id is now a nullable type. nullable types are class wrappers around the value.
            // in order to access the value of a nullable property, you must access it by
            // propertyName.Value
            var original = _service.Find(id.Value);

            if (original == null)
            {
                return View("AlbumDoesNotExist");
            }

            return View(original);
        }

        // POST: Albums/Edit/5
        [HttpPost]
        public ActionResult Edit(Album album)
        {
            if (ModelState.IsValid)
            {
                _service.Edit(album);
                return RedirectToAction("Index");

            }

            return View();
            
        }

        // GET: Albums/Delete/5
        public ActionResult Delete(int id)
        {
            var original = _service.Find(id);
            return View(original);
        }

        // POST: Albums/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteReally(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}

using _16hrApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16hrApp.Controllers
{
    public class AnalysisController : Controller
    {
        ToDoListDb _db = new ToDoListDb();

        //
        // GET: /Analysis/

        public ActionResult Index()
        {
            var model = from i in _db.ToDoListItems
                        where (i.Day == "monday")
                        select i;
            return View(model);
        }

        public ActionResult Monday()
        {
            var model = from i in _db.ToDoListItems
                        where (i.Day == "monday")
                        select i;

            return PartialView("_Analysis", model);
        }

        public ActionResult Tuesday()
        {
            var model = from i in _db.ToDoListItems
                        where (i.Day == "tuesday")
                        select i;

            return PartialView("_Analysis", model);
        }

        public ActionResult Wednesday()
        {
            var model = from i in _db.ToDoListItems
                        where (i.Day == "wednesday")
                        select i;

            return PartialView("_Analysis", model);
        }

        public ActionResult Thursday()
        {
            var model = from i in _db.ToDoListItems
                        where (i.Day == "thursday")
                        select i;

            return PartialView("_Analysis", model);
        }

        public ActionResult Friday()
        {
            var model = from i in _db.ToDoListItems
                        where (i.Day == "friday")
                        select i;

            return PartialView("_Analysis", model);
        }

        public ActionResult Saturday()
        {
            var model = from i in _db.ToDoListItems
                        where (i.Day == "tuesday")
                        select i;

            return PartialView("_Analysis", model);
        }

        public ActionResult Sunday()
        {
            var model = from i in _db.ToDoListItems
                        where (i.Day == "sunday")
                        select i;

            return PartialView("_Analysis", model);
        }

        //
        // GET: /Analysis/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Analysis/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Analysis/Create

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

        //
        // GET: /Analysis/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Analysis/Edit/5

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

        //
        // GET: /Analysis/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Analysis/Delete/5

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

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

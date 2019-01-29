using _16hrApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16hrApp.Controllers
{
    public class ToDoListController : Controller
    {
        //
        // GET: /ToDoList/
        ToDoListDb _db = new ToDoListDb();

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

            return PartialView("_ToDoList", model);
        }

        public ActionResult Tuesday()
        {
            var model = from i in _db.ToDoListItems
                        where (i.Day == "tuesday")
                        select i;

            return PartialView("_ToDoList", model);
        }

        public ActionResult Wednesday()
        {
            var model = from i in _db.ToDoListItems
                        where (i.Day == "wednesday")
                        select i;

            return PartialView("_ToDoList", model);
        }

        public ActionResult Thursday()
        {
            var model = from i in _db.ToDoListItems
                        where (i.Day == "thursday")
                        select i;

            return PartialView("_ToDoList", model);
        }

        public ActionResult Friday()
        {
            var model = from i in _db.ToDoListItems
                        where (i.Day == "friday")
                        select i;

            return PartialView("_ToDoList", model);
        }

        public ActionResult Saturday()
        {
            var model = from i in _db.ToDoListItems
                        where (i.Day == "tuesday")
                        select i;

            return PartialView("_ToDoList", model);
        }

        public ActionResult Sunday()
        {
            var model = from i in _db.ToDoListItems
                        where (i.Day == "sunday")
                        select i;

            return PartialView("_ToDoList", model);
        }


        //
        // GET: /ToDoList/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /ToDoList/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ToDoList/Create

        [HttpPost]
        public ActionResult Create(ToDoListItem item)
        {
            if (ModelState.IsValid)
            {
                _db.ToDoListItems.Add(item);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(item);
        }

        //
        // GET: /ToDoList/Edit/5

        public ActionResult Edit(int id)
        {
            var model = _db.ToDoListItems.Find(id);
            return View(model);
        }

        //
        // POST: /ToDoList/Edit/5

        [HttpPost]
        public ActionResult Edit(ToDoListItem item)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(item).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(item);
        }

        //
        // GET: /ToDoList/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ToDoListItem item = _db.ToDoListItems.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }
        //
        // POST: /ToDoList/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ToDoListItem item = _db.ToDoListItems.Find(id);
            _db.ToDoListItems.Remove(item);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}

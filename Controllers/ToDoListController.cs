using _16hr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16hr.Controllers
{
    public class ToDoListController : Controller
    {
        //
        // GET: /ToDoList/

        public ActionResult Index()
        {
            var model = from t in _ToDoList
                        orderby t.DateBegin
                        select t;
            return View(model);
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
        // GET: /ToDoList/Edit/5

        public ActionResult Edit(int id)
        {
            var ToDoListItem = _ToDoList.Single(t => t.Id == id); 
            return View(ToDoListItem);
        }

        //
        // POST: /ToDoList/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var ToDoListItem = _ToDoList.Single(t => t.Id == id);
            if (TryUpdateModel(ToDoListItem))
            {
                return RedirectToAction("Index");
            }
            return View(ToDoListItem);
        }

        //
        // GET: /ToDoList/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ToDoList/Delete/5

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

        static List<ToDoListItem> _ToDoList = new List<ToDoListItem>
        {
            new ToDoListItem
            {
                Id = 1,
                DateEnd = "March 5",
                DateBegin = "March 4",
                Message = "hello"
            }
        };
    }
}

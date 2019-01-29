using _16hrApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _16hrApp.Controllers
{
    public class HomeController : Controller
    {
        ToDoListDb _db = new ToDoListDb();

        public ActionResult Index()
        {
            var model = _db.Days.ToList();

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "The app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "The contact page.";

            return View();
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

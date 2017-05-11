using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using portfolio4.Models;
using portfolio4.DataContext;

namespace portfolio4.Controllers
{
    public class HomeController : Controller
    {
        private ProjectContext db = new ProjectContext();

        public ActionResult Index(int? id)
        {
            Project project = db.Projects.Find(id);
            return View(project);
        }

        public ActionResult About()
        {
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
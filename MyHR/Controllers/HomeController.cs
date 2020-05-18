using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyHR.Library.ActionResults;
using MyHR.Library.ActionFilter;

namespace MyHR.Controllers
{
    public class HomeController : Controller
    {
        [ActionLogFilter]
        public ActionResult Index()
        {
            return View();
        }

        [ActionLogFilter]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [ActionLogFilter]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ActionLogFilter]
        public FileActionResult UserGuideFile()
        {
            return new FileActionResult("UserGuide.pdf", "~/Files/", "application/pdf");
        }

        [ActionLogFilter]
        public FileActionResult AboutFile()
        {
            return new FileActionResult("AboutFile.pdf", "~/Files/", "application/pdf");
        }

        //[Authorize(Roles = "Admin")]
        public ActionResult ActionLog()
        {
            using (MyHR.Models.MyHREntities myDB = new Models.MyHREntities())
            {
                var ActionLogs = (from a in myDB.AcionLogs select a).ToList();

                return View(ActionLogs);
            }
        }
    }
}
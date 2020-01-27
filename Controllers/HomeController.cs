using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrubakerMIS4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My MIS 4200 Home Page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Info About Michael.";

            return View();
        }
    }
}
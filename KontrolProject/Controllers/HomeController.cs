using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KontrolProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Privacy()
        {
            ViewBag.Message = "Your Privacy page.";

            return View();
        }

        public ActionResult Licenses()
        {
            ViewBag.Message = "Our licenses page.";

            return View();
        }

        public ActionResult Faq()
        {
            ViewBag.Message = "Frequently Asked Questions.";

            return View();
        }
    }
}
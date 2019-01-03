using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventRegistrationSystem.Controllers
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


        public ViewResult Events()
        {
            ViewBag.Message = "Employees view events here.";
            
            //todo: go get events

            return View();
        }

        public ViewResult CreateEvent()
        {
            ViewBag.Message = "Create a new Event here.";
            return View();
        }

        public ActionResult Gallery()
        {
            ViewBag.Message = "Day of Differnece Gallery Page.";

            return View();
        }
    }
}
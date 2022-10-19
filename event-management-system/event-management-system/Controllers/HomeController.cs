using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace event_management_system.Controllers
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
        public ActionResult SportsReviews()
        {
            ViewBag.Message = "Your Sports Review page.";

            return View();
        }
        public ActionResult MotorSportsReviews()
        {
            ViewBag.Message = "Your Motor sports Review page.";

            return View();
        }
        public ActionResult RageExpoReviews()
        {
            ViewBag.Message = "Your Rage expo Review page.";

            return View();
        }
    }
}
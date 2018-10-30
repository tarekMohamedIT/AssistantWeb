using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssistantWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Route("about")]
        public ActionResult About()
        {
            ViewBag.Message = "The best of assistant's four cores in one website!";

            return View();
        }

        [Route("about/notes")]
        public ActionResult AboutNotes()
        {
            return View();
        }

        [Route("about/money")]
        public ActionResult AboutMoney()
        {
            return View();
        }

        [Route("contact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
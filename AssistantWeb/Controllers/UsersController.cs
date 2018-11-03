using AssistantWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssistantWeb.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Login(User user)
        {
            return Content(string.Format(
                "<type>{0}</type><email>{1}</email><message>{2}</message>",
                "success",
                user.Email,
                "User logged in successfully!"));
        }

        public ActionResult Register(User user)
        {
            return Content(string.Format(
               "<type>{0}</type><email>{1}</email><message>{2}</message>",
               "success",
               user.Email,
               "User logged in successfully!"));
        }

        public ActionResult Index()
        {
            return View(new User());
        }
    }
}
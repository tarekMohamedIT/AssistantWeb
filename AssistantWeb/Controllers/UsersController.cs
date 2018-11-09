using AssistantWeb.Models.Users;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssistantWeb.Controllers
{
    public class UsersController : Controller
    {

        [HttpPost]
        [Route("users/login")]
        public ActionResult Login(User user)
        {
            if (user.Id == -1)
                user.Id = 2;


            UserStatus status = new UserStatus()
            {
                UserId = user.Id,

                Message = "Logged in successfully"
            };

            Session.Add("_loginId", status);

            return Redirect("/Home");
        }

        [Route("users/register")]
        [HttpPost]
        public ActionResult Register(User user)
        {
            if (user.Id == -1)
                user.Id = 2;

            UserStatus status = new UserStatus()
            {
                UserId = user.Id,

                Message = "Registered new user successfully"
            };

            return Redirect("/Home");
        }

        public ActionResult Index()
        {
            return View(new User());
        }

        [Route("users/{Id}")]
        public ActionResult Index(int Id = 1)
        {
            return View(new User());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IPTFINALS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Products()
        {
            return View();
        }
        public ActionResult AdminAccess()
        {
            return View();
        }

        public ActionResult Customer()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Registration()
        {
            return View();
        }
        public ActionResult NewUserRegistration()
        {
            return View();
        }
    }
   } 
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSignup.Controllers
{
    public class HomeController : Controller
    {
       public static int RegistrationStep = 1;
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

        public ActionResult Register()
        {
            ViewBag.Message = "Your register page.";

            return View();
        }
        public ActionResult Validate()
        {
            ViewBag.Message = "Your register page.";

            return View();
        }
    }
}
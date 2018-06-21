using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CreditDemoWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Our company is all about credit.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "This is our contact page. Please get in touch.";

            return View();
        }
    }
}
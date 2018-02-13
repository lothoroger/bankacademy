using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bankacademy.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "ASP.NET/MVC/C# combined with Data Warehouse Skills / Business Intelligence.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "You can get in touch with me via e-Mail or Cellphone.";

            return View();
        }
    }
}
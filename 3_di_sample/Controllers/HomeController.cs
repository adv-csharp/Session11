using _3_di_sample.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3_di_sample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILog _log;

        public HomeController(ILog log)
        {
            _log = log;
        }
        public ActionResult Index()
        {
            _log.Warn("Salam");
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
    }
}
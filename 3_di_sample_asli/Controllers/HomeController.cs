using _3_di_sample_asli.Models;
using _3_di_sample_asli.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _3_di_sample_asli.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILog _log;

        public HomeController(ILogger<HomeController> logger, ILog log)
        {
            _logger = logger;
            _log = log;
        }

        public IActionResult Index()
        {
            _log.Info("Salam");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
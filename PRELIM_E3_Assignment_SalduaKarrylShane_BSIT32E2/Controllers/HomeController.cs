using Microsoft.AspNetCore.Mvc;
using PRELIM_E3_Assignment_SalduaKarrylShane_BSIT32E2.Models;
using System.Diagnostics;

namespace PRELIM_E3_Assignment_SalduaKarrylShane_BSIT32E2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(new { Name = "Karryl Shane S. Saldua", Course = "BSIT", Section = "32E2" });
        }

        public IActionResult School()
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

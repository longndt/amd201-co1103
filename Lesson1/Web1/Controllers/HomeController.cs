using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web1.Models;

namespace Web1.Controllers
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

        //URL: localhost:PORT_NO/Home/Demo
        public IActionResult Demo()
        {
            //File: Views/Home/Demo.cshtml
            return View();
        }

        //URL: localhost:PORT_NO/Home/Greenwich
        public IActionResult Greenwich()
        {
            //File: Views/Home/Greenwich.cshtml
            return View();
        }
    }
}

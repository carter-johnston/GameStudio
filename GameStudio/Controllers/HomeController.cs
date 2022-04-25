using GameStudio.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GameStudio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //Static pages:
        public IActionResult Index()
        {
            ViewData["NavigationMenu"] = "Index";
            return View();
        }
        public IActionResult AboutUs()
        {
            ViewData["NavigationMenu"] = "AboutUs";
            return View();
        }
        public IActionResult FAQ()
        {
            ViewData["NavigationMenu"] = "FAQ";
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}

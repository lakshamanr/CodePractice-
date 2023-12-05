using DI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMyLocalLoger _logger;

        public HomeController(IMyLocalLoger myLocalLoger)
        {
            _logger = myLocalLoger;
        }

        public IActionResult Index()
        {
            _logger.Print("Hello");
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
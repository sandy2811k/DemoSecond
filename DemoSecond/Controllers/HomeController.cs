using DemoSecond.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoSecond.Controllers
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
            ViewData["message"] = "Hi......Good Morning/Good Afternoon/Good Evening";
            List<string> names = new List<string>()
            {
                "Akash" , "Ram" , "Shree" , "Vishal" , "Chidanand"
            };
            ViewData["list"] = names; // implict --> object


            //Working with ViewBag
            ViewBag.Year = 2020;
            ViewBag.Month = "Oct";
            ViewBag.names = names;

            //Working with TempData
            TempData["Company"] = "Think Quotient";
            TempData.Keep("Company");

            List<string> Cities = new List<string>()
            {
                "Pune" , "Mumbai" , "Benglore" , "Nashik" , "Belgaum"
            };
            ViewData["list1"] = Cities; // implict --> object
            return View();
            return View();
        }

        public IActionResult Privacy()
        {
            var name = TempData["Company"];
            //Remove the values from tempdata
            TempData.Clear();
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
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
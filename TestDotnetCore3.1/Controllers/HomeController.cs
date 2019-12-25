using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestDotnetCore3._1.Models;

namespace TestDotnetCore3._1.Controllers
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
			//string test = "abc";
            //ZipFile.Create("test.zip");										   
            return View();
        }
		
		public IActionResult About()
        {
            ViewData["Message"] = "About";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet] //default
        public IActionResult Numbers()
        {
            return View();
        }
        
        [HttpPost]
		public IActionResult Numbers(int start=10, int end=20)
        {
            var nums = new List<int>();
            for (int i = start; i <= end; i++)
            {
                nums.Add(i);
            }
            ViewBag.Nums = nums;
            ViewBag.Start = start;
            ViewBag.End = end;

            return View();
        }
		
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

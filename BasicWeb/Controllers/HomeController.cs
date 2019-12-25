using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BasicWeb.Models;
//using ICSharpCode.SharpZipLib.Zip;

namespace BasicWeb.Controllers
{
    public class HomeController : Controller
    {
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

        public IActionResult GetPrivacy()
        {
            return View();
        }

        public IActionResult Numbers()
        {
            var nums = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                nums.Add(i);
            }
            ViewBag.Nums = nums;
            ViewBag.Title = "Заглавие на страницата";

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

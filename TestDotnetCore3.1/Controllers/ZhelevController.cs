using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BasicWeb.Controllers
{
    public class ZhelevController : Controller
    {
        public IActionResult Index()
        {
            int v = new Random().Next(1, 101);
            ViewBag.Rand = v;
            return View();
        }

        public dynamic Hello() 
        {
            return new
            {
                count = 1,
                users = new string[] 
                {
                    "pesho",
                    "gosho"
                }
            };
        }
    }
}

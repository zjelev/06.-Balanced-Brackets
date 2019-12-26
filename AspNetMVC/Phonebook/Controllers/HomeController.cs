using Phonebook.Data.Models;
using Phonebook.Data;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Phonebook.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new List<Contact>());
        }
    }
}

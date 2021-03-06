using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Phonebook.Data;
using Phonebook.Data.Models;

namespace Phonebook.Controllers
{
    public class ContactController : Controller
    {
        private static int idCounter = 1;

        public IActionResult Create(string name, string number)
        {
            Contact contact = new Contact(idCounter, name, number);

            DataAccess.Contacts.Add(contact);

            idCounter++;
            
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Remove(int id)
        {
            var contact = DataAccess.Contacts.FirstOrDefault(x => x.Id == id);

            if (contact != null)
            {
                DataAccess.Contacts.Remove(contact);
            }
            

            return RedirectToAction("Index", "Home");
        }
    }
}
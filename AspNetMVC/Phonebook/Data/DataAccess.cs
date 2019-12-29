using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.Azure.KeyVault.Models;
using Phonebook.Data.Models;

namespace Phonebook.Data
{
    public class DataAccess
    {
        public static List<Contact> Contacts { get; set; } 
        
        static DataAccess()
        {
            Contacts = new List<Contact>();
        }
    }
}
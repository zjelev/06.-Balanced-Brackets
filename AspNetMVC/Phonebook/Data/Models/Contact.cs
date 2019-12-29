using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phonebook.Data.Models
{
    public class Contact
    {
        public Contact(int id, string name, string number)
        {
            this.Id = id;
            this.Name = name;
            this.Number = number;
        }
        //[Required] 
        public int Id { get; set; }
        public string Name { get; set; }
        //[Required] 
        public string Number { get; set; }
    }
}
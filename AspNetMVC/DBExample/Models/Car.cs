using System;
using System.ComponentModel.DataAnnotations;

namespace DBExample.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
    }
}
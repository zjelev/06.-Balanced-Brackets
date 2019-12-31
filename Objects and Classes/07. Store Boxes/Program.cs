using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Store_Boxes
{
    class StoreBoxes
    {
        static void Main(string[] args)
        {
            string input;

            List<Box> boxes = new List<Box>();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] token = input.Split(' ');

                Box box = new Box();
                box.Item = new Item();

                box.SerialNumber = int.Parse(token[0]);
                box.Item.Name = token[1];
                box.ItemQnty = int.Parse(token[2]);
                box.Item.Price = double.Parse(token[3]);
                box.Price = box.ItemQnty * box.Item.Price;

                boxes.Add(box);
            }

            List<Box> sortedBoxes = boxes.OrderByDescending(b => b.Price).ToList();

            foreach (var box in sortedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQnty}");
                Console.WriteLine($"-- ${box.Price:f2}");
            }

        }
    }

    class Box 
    {
        public int SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQnty { get; set; }

        public double Price { get; set; }
    }

    class Item
    {
        public string Name { get; set; }

        public double Price { get; set; }
    }
}

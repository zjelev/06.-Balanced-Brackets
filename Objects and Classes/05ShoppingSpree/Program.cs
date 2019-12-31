using System;
using System.Collections.Generic;
using System.Linq;

namespace _05ShoppingSpree
{
    class Program
    {
        static void Main()
        {
            string[] personMoney = Console.ReadLine().Split(';');

            List<Person> people = new List<Person>();

            foreach (var item in personMoney)
            {
                string[] personMoneySplit = item.Split('=');
                Person person = new Person(personMoneySplit[0], decimal.Parse(personMoneySplit[1]));

                people.Add(person);
            }

            string[] productCost = Console.ReadLine().Split(';');

            List<Product> products = new List<Product>();

            foreach (var item in productCost)
            {
                string[] productCostSplit = item.Split('=');
                Product product = new Product(productCostSplit[0], decimal.Parse(productCostSplit[1]));

                products.Add(product);
            }

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] personProduct = input.Split(' ');
                string person = personProduct[0];
                string product = personProduct[1];

                int personIndex = people.FindIndex(x => x.Name == person);
                int productIndex = products.FindIndex(x => x.Name == product);
                
                if (products[productIndex].Cost <= people[personIndex].Money)
                {
                    people[personIndex].Bag.Add(products[productIndex]);
                    Console.WriteLine($"{people[personIndex]} bought {products[productIndex]}");
                    people[personIndex].Money -= products[productIndex].Cost;
                }
                else
                {
                    Console.WriteLine($"{people[personIndex]} can't afford {products[productIndex]}");
                }
            }
            
            foreach (var item in people)
            {
                Console.Write($"{item.Name} - ");
                if (item.Bag.Count > 0)
                {
                    Console.WriteLine(string.Join(", ", item.Bag));
                }
                else
                {
                    Console.WriteLine("Nothing bought");
                }
            }
        }
    }

    class Person
    {
        public string Name {get; set;}

        public decimal Money {get; set;}

        public List<Product> Bag {get; set;}

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.Bag = new List<Product>();
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }

    }

    class Product
    {
        public string Name {get; set;}

        public decimal Cost {get; set;}

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}

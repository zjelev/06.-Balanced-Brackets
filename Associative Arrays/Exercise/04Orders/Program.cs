using System;
using System.Collections.Generic;
using System.Linq;

namespace _04Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, ProductPrice>();

            string[] input = Console.ReadLine().Split(' ');
            while (input[0] != "buy")
            {
                string productName = input[0];
                double productPrice = double.Parse(input[1]);
                int productQty = int.Parse(input[2]);
                
                if (!products.ContainsKey(productName))
                {
                    products[productName] = new ProductPrice(productPrice, productQty);
                }
                else{
                products[productName].Quantity += productQty;
                products[productName].Price = productPrice;
                }
                input = Console.ReadLine().Split(' ');
            }

            foreach (var kvp in products)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Price * kvp.Value.Quantity:f2}");
            }
        }
    }

    class ProductPrice
    {
        public double Price { get; set; }

        public int Quantity {get; set; }

        public ProductPrice(double price, int quantity)
        {
            this.Price = price;
            this.Quantity = quantity;
        }
    }
}
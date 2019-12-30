using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 0;
            decimal order = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Start")
                {
                    break;
                }
                else
                {
                    decimal coin = decimal.Parse(input);
                    if (coin.Equals(0.1m) || coin.Equals(0.2m) || coin.Equals(0.5m) || coin.Equals(1) || coin.Equals(2))
                    {
                        sum += coin;
                    }
                    else
                    {
                        Console.WriteLine("Cannot accept " + coin);
                    }
                }
            }
            while (sum >= order)
            {
                string product = Console.ReadLine();
                if (product.Equals("Coke"))
                {
                    order += 1m;
                    if (sum >= order)
                    {
                        Console.WriteLine("Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        order -= 1m;
                        break;
                    }
                }
                else if (product.Equals("Soda") && sum >= order)
                {
                    order += 0.8m;
                    if (sum >= order)
                    {
                        Console.WriteLine("Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        order -= 0.8m;
                        break;
                    }
                }
                else if (product.Equals("Crisps") && sum >= order)
                {
                    order += 1.5m;
                    if (sum >= order)
                    {
                        Console.WriteLine("Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        order -= 1.5m;
                        break;
                    }
                }
                else if (product.Equals("Nuts") && sum >= order)
                {
                    order += 2m;
                    if (sum >= order)
                    {
                        Console.WriteLine("Purchased nuts");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        order -= 2m;
                        break;
                    }
                }
                else if (product.Equals("Water") && sum >= order)
                {
                    order += 0.7m;
                    if (sum >= order)
                    {
                        Console.WriteLine("Purchased water");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        order -= 0.7m;
                        break;
                    }
                }
                else if (product.Equals("End"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                }
            Console.WriteLine("Change: {0:0.00}", sum - order);
        }
    }
}
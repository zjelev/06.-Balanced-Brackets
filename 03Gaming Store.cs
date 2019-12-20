using System;

namespace _07._Gaming_Store
    {
        class Program
        {
            static void Main(string[] args)
            {
                decimal sum = decimal.Parse(Console.ReadLine());
                decimal order = 0;
                while (sum >= order)
                {
                    string product = Console.ReadLine();
                    if (product.Equals("OutFall 4"))
                    {
                        order += 39.99m;
                        if (sum > order)
                        {
                            Console.WriteLine("Bought OutFall 4");
                        }
                        else if (sum < order)
                        {
                            Console.WriteLine("Too Expensive");
                            order -= 39.99m;
                        }
                        else
                        {
                            Console.WriteLine("Out of money!");
                            break;
                        }
                    }
                    else if (product.Equals("CS: OG"))
                    {
                        order += 15.99m;
                        if (sum >= order)
                        {
                            Console.WriteLine("Bought CS: OG");
                        }
                        else if (sum < order)
                        {
                            Console.WriteLine("Too Expensive");
                            order -= 15.99m;
                        }
                        else
                        {
                            Console.WriteLine("Out of money!");
                            break;
                        }
                    }
                    else if (product.Equals("Zplinter Zell"))
                    {
                        order += 19.99m;
                        if (sum >= order)
                        {
                            Console.WriteLine("Bought Zplinter Zell");
                        }
                        else if (sum < order)
                        {
                            Console.WriteLine("Too Expensive");
                            order -= 19.99m;
                        }
                        else
                        {
                            Console.WriteLine("Out of money!");
                            break;
                        }
                    }
                    else if (product.Equals("Honored 2"))
                    {
                        order += 59.99m;
                        if (sum >= order)
                        {
                            Console.WriteLine("Bought Honored 2");
                        }
                        else if (sum < order)
                        {
                            Console.WriteLine("Too Expensive");
                            order -= 59.99m;
                        }
                        else
                        {
                            Console.WriteLine("Out of money!");
                            break;
                        }
                    }
                    else if (product.Equals("RoverWatch Origins Edition"))
                    {
                        order += 39.99m;
                        if (sum >= order)
                        {
                            Console.WriteLine("Bought RoverWatch Origins Edition");
                        }
                        else if (sum < order)
                        {
                            Console.WriteLine("Too Expensive");
                            order -= 39.99m;
                        }
                        else
                        {
                            Console.WriteLine("Out of money!");
                            break;
                        }
                    }
                    else if (product.Equals("RoverWatch"))
                    {
                        order += 29.99m;
                        if (sum >= order)
                        {
                            Console.WriteLine("Bought RoverWatch");
                        }
                        else if (sum < order)
                        {
                            Console.WriteLine("Too Expensive");
                            order -= 29.99m;
                        }
                        else
                        {
                            Console.WriteLine("Out of money!");
                            break;
                        }
                    }
                    else if (product.Equals("Game Time"))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not Found");
                    }
                }
                if (sum == order)
                {
                    Console.WriteLine("Out of money!");
                }
                else
                    Console.WriteLine("Total spent: ${0:0.00}. Remaining: ${1:0.00}", order, sum - order);
            }
        }
    }
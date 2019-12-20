using System;

namespace _08.Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string evaluation = Console.ReadLine();

            int nights = days - 1;

            double price = 18;

            if (roomType == "apartment")
            {
                price = 25;
                if (days < 10)
                {
                     price *= 0.7;
                }
                else if (10 <= days && days <= 15)
                {
                    price *= 0.65;
                }
                else
                {
                    price *= 0.5;
                }
            }
            else if (roomType == "president apartment")
            {
                price = 35;
                if (days < 10)
                {
                    price *= 0.9;
                }
                else if (10 <= days && days <= 15)
                {
                    price *= 0.85;
                }
                else
                {
                    price *= 0.8;
                }
            }

            if (evaluation == "positive")
            {
                price *= 1.25;
            }
            else if (evaluation == "negative")
            {
                price *= 0.9;
            }

            Console.WriteLine($"{price * nights:f2}");
            
        }
    }
}

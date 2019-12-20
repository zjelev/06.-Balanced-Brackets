using System;

namespace _02.Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = string.Empty;
            if (budget <= 100)
            {
                destination = "BG";
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
            }
            else
            {
                destination = "EU";
            }
            if (season = "summer")
            {

            }
        }
    }
}

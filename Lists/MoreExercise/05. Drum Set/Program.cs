using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    class Program
    {
        static void Main()
        {
            double savings = double.Parse(Console.ReadLine());

            List<int> drums = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> drumsInitital = drums.ToList(); //new List<int>(drums);

            string input;

            while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int power = int.Parse(input);

                for (int i = 0; i < drums.Count; i++)
                {
                    if (drums[i] > 0)
                    {
                        drums[i] -= power;

                        if (drums[i] <= 0)
                        {
                            double price = drumsInitital[i] * 3;
                            if (price <= savings)
                            {
                                savings -= price;
                                drums[i] = drumsInitital[i];
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < drums.Count; i++)
            {
                if (drums[i] <= 0)
                {
                    drums.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine(string.Join(" ", drums));

            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
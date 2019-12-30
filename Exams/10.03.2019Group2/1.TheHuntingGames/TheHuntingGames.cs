using System;

namespace _10_March_2019
{
    class TheHuntingGames
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double waterPerDayPerPerson = double.Parse(Console.ReadLine());
            double foodPerDayPerPerson = double.Parse(Console.ReadLine());

            double food = days * players * foodPerDayPerPerson;
            double water = days * players * waterPerDayPerPerson;

            bool success = true;

            for (int i = 1; i <= days; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());
                if (energyLoss < energy)
                {
                    energy -= energyLoss;
                }
                else
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {food:f2} food and {water:f2} water.");
                    success = false;
                    break;
                }

                if (i % 2 == 0)
                {
                    energy *= 1.05;
                    water *= 0.7;
                }

                if (i % 3 == 0)
                {
                    food -= food / players;
                    energy *= 1.1;
                }   
            }

            if (success)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {energy:f2} energy!");
            }
        }
    }
}

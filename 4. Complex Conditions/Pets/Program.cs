using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int leftFood = int.Parse(Console.ReadLine());

            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turtleFood = double.Parse(Console.ReadLine()) / 1000;

            double neededFood = days * (dogFood + catFood + turtleFood);

            if (leftFood >= neededFood)
            {
                Console.WriteLine($"{Math.Floor(leftFood - neededFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(neededFood - leftFood)} more kilos of food are needed.");
            }

        }
    }
}

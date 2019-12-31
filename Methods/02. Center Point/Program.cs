using System;

namespace _02._Center_Point
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double h1 = DistanceToCenter(x1, y1);
            double h2 = DistanceToCenter(x2, y2);
            
            if (h1 <= h2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        private static double DistanceToCenter(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}
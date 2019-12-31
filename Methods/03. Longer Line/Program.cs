using System;

namespace _03._Longer_Line
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            
            double line1 = Line(x1, y1, x2, y2);
            double line2 = Line(x3, y3, x4, y4);

            if (line1 >= line2)
            {
                PrintLineFromClosestToCenterEnd(x1, y1, x2, y2);
            }
            else
            {
                PrintLineFromClosestToCenterEnd(x3, y3, x4, y4);
            }
        }

        private static void PrintLineFromClosestToCenterEnd(double x1, double y1, double x2, double y2)
        {
            double h1 = Hipotenuza(x1, y1);
            double h2 = Hipotenuza(x2, y2);

            if (h1 <= h2)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }

        private static double Line(double x1, double y1, double x2, double y2)
        {
            double x = Math.Abs(x1 - x2);
            double y = Math.Abs(y1 - y2);
            double h = Hipotenuza(x, y);
            return h;
        }

        private static double Hipotenuza(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }
    }
}

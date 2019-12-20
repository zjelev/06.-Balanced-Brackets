using System;

namespace _09.House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int stars = 1;
            if (n%2==0)
            {
                stars++;
            }
            int roofLength = (int)Math.Ceiling(n / 2f);
            for (int i = 0; i < roofLength; i++)
            {
                int padding = (n - stars) / 2;
                var line = new string('-', padding)
                    + new string('-', stars)
                    + new string('-', padding);
                Console.WriteLine(line);
                stars += 2;
            }
            for (int i = 0; i < n / 2; i++)
            {
                var line = "|" + new string('*', n - 2) + "|";
                Console.WriteLine(line);
            }
        }
    }
}
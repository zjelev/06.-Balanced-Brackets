using System;

namespace _07._Water_Overflow
{
    class WaterOverflow
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            ushort sum = 0;
            for (int i = 0; i < n; i++)
            {
                ushort litres = ushort.Parse(Console.ReadLine());
                sum += litres;
                if (sum > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= litres;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
using System;

namespace _08._Beer_Kegs
{
    class BeerKegs
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            string biggestModel = "";
            double biggestVol = 0;
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * radius * radius * height;
                if (volume > biggestVol)
                {
                    biggestVol = volume;
                    biggestModel = model;
                }
            }
            Console.WriteLine(biggestModel);
        }
    }
}

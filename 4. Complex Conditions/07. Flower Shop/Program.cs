using System;

namespace _07.Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolii = int.Parse(Console.ReadLine());
            int zumbul = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactus = int.Parse(Console.ReadLine());

            double priceGift = double.Parse(Console.ReadLine());

            double totalOrder = magnolii * 3.25 + zumbul * 4 + roses * 3.5 + cactus * 8;
            totalOrder *= 0.95;

            if (priceGift <= totalOrder)
            {
                Console.WriteLine($"She is left with {Math.Floor(totalOrder - priceGift)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(priceGift - totalOrder)} leva.");
            }
        }
    }
}

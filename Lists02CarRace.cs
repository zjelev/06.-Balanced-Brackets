using System;
using System.Linq;

namespace _02._Car_Race
{
    class Min3Numbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            var smallest3Nums = numbers.OrderBy(i => i).Take(3);

            foreach (var num in smallest3Nums)
            {
                Console.WriteLine(num);
            }
        }
    }
}

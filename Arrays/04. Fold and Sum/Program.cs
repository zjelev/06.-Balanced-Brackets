using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(" ")
                .Select(int.Parse)
                .ToArray();

            int[] firstRow = new int[numbers.Length / 2];
            int[] secondRow = new int[numbers.Length / 2];

            for (int i = 0; i < numbers.Length / 4 ; i++)
            {
                firstRow[firstRow.Length / 2 - i - 1] = numbers[i];
                firstRow[firstRow.Length - i - 1] = numbers[i + numbers.Length / 4 * 3];
            }

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                secondRow[i] = numbers[i + numbers.Length / 4];
            }

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                Console.Write(firstRow[i] + secondRow[i] + " ");
            }

            Console.WriteLine();
            //Console.WriteLine(string.Join(" ", secondRow));
        }
    }
}

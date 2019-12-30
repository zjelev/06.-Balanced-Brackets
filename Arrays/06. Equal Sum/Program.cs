using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            //bool areSumsEqual = false;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    int sumLeft = 0;
            //
            //    for (int j = 0; j < i; j++)
            //    {
            //        sumLeft += numbers[j];
            //    }
            //
            //    int sumRight = 0;
            //
            //    for (int j = i+1; j < numbers.Length; j++)
            //    {
            //        sumRight += numbers[j];
            //    }
            //
            //    if (sumRight == sumLeft)
            //    {
            //        Console.WriteLine(i);
            //        areSumsEqual = true;
            //        break;
            //    }
            //}
            //
            //if (!areSumsEqual)
            //{
            //    Console.WriteLine("no");
            //}

            int leftSum = 0;
            int rightSum = numbers.Sum();

            for (int i = 0; i < numbers.Length; i++)
            {
                rightSum -= numbers[i];

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }

                leftSum += numbers[i];
            }

            Console.WriteLine("no");
        }
    }
}

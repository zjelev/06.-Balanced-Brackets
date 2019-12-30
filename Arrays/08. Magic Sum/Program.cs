using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sumToCheck = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == sumToCheck)
                    {
                        Console.WriteLine(numbers[i] + " " + numbers[j]);
                    }    
                }
            }
        }
    }
}
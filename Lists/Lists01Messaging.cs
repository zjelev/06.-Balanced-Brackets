using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine()
                .Split(" ")
                .Select(x => int.Parse(x))
                .ToList();

            List<string> text = Console.ReadLine().Split(" ").ToList();

            for (int i = 0; i < nums.Count; i++)
            {
                int currentNum = nums[i];
                int sum = 0;

                while (currentNum > 0)
                {
                    int currentDigit = currentNum % 10;
                    sum += currentDigit;
                    currentNum /= 10;
                }

                int elementIndex = sum % text.Count;

                text.RemoveAt(elementIndex);   
            }

            Console.WriteLine(string.Join("", text));
        }
    }
}

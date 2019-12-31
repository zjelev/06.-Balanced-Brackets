using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main()
        {
            List<int> first = Console.ReadLine()
                .Split(" ")
                .Select(x => int.Parse(x))
                .ToList();

            List<int> second = Console.ReadLine()
                .Split(" ")
                .Select(x => int.Parse(x))
                .ToList();

            int i = 0;
            while (first.Count > 0 && second.Count > 0)
            {
                if (first[i] > second[i])
                {
                    TakeHand(first, second, i);
                    i--;
                }
                else if (first[i] < second[i])
                {
                    TakeHand(second, first, i);
                    i--;
                }
                else
                {
                    first.RemoveAt(i);
                    second.RemoveAt(i);
                    i--;
                }
                i++;
            }

            int sum = 0;
            if (first.Count == 0)
            {
                for (int j = 0; j < second.Count; j++)
                {
                    sum += second[j];
                }

                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
            else
            {
                for (int j = 0; j < first.Count; j++)
                {
                    sum += first[j];
                }
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
        }

        private static void TakeHand(List<int> first, List<int> second, int i)
        {
            first.Add(first[i]);
            first.RemoveAt(i);
            first.Add(second[i]);
            second.RemoveAt(i);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main()
        {
            List<int> firstList = Console.ReadLine().Split()
                .Select(int.Parse).ToList();

            List<int> secondList = Console.ReadLine().Split()
                .Select(int.Parse).ToList();

            List<int> result = new List<int>();

            int diffCount = Math.Abs(firstList.Count - secondList.Count);

            for (int i = 0; i < Math.Min(firstList.Count, secondList.Count); i++)
            {
                result.Add(firstList[i]);
                result.Add(secondList[i]);
            }

            if (firstList.Count > secondList.Count)
            {
                for (int i = firstList.Count - diffCount; i < firstList.Count; i++)
                {
                    result.Add(firstList[i]);
                }
            }
            else
            {
                for (int i = secondList.Count - diffCount; i < secondList.Count; i++)
                {
                    result.Add(secondList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
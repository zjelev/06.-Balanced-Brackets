//The description of the tasks is terrible!

using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
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

            int shorterListCount = second.Count;
            int rangeFrom = first[first.Count - 1];
            int rangeTo = first[first.Count - 2];

            if (second.Count > first.Count)
            {
                shorterListCount = first.Count;
                rangeFrom = second[0];
                rangeTo = second[1];
            }

            if (rangeFrom > rangeTo)
            {
                int temp = rangeFrom;
                rangeFrom = rangeTo;
                rangeTo = temp;
            }

            List<int> mixed = new List<int>();

            for (int i = 0; i < shorterListCount; i++)
            {
                mixed.Add(first[i]);
                mixed.Add(second[second.Count - 1 - i]);
            }


            List<int> sorted = new List<int>();

            for (int i = 0; i < mixed.Count; i++)
            {
                if (mixed[i] > rangeFrom && mixed[i] < rangeTo)
                {
                    sorted.Add(mixed[i]);
                }
            }

            //Console.WriteLine(string.Join(" ", sorted));

            sorted.Sort();

            Console.WriteLine(string.Join(" ", sorted));
        }
    }
}

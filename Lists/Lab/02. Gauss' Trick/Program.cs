using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split()
                .Select(int.Parse).ToList();

            int end = nums.Count - 1;
            int middle = nums.Count / 2;       

            for (int i = 0; i < middle; i++)
            {
                nums[i] += nums[end - i];
                nums.RemoveAt(nums.Count - 1);
            }

            Console.WriteLine(string.Join(" ", nums));
        }   
    }
}

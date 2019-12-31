using System;
using System.Collections.Generic;

namespace _03._Take_Skip_Rope
{
    class Program
    {
        static void Main()
        {
            string encrypted = Console.ReadLine();

            List<int> nums = new List<int>();
            List<char> nonNums = new List<char>();

            for (int i = 0; i < encrypted.Length; i++)
            {
                if (encrypted[i] >= '0' && encrypted[i] <= '9' )
                {
                    nums.Add(int.Parse(encrypted[i].ToString()));
                }
                else
                {
                    nonNums.Add(encrypted[i]);
                }
            }

            List<int> takeNums = new List<int>();
            List<int> skipNums = new List<int>();

            for (int i = 0; i < nums.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeNums.Add(nums[i]);
                }
                else
                {
                    skipNums.Add(nums[i]);
                }
            }

            string result = String.Empty;
            int skipCount = 0;

            for (int i = 0; i < takeNums.Count; i++)
            {
                for (int j = skipCount; j < skipCount + takeNums[i] && j < nonNums.Count; j++)
                {
                    result += nonNums[j];
                }
                skipCount += skipNums[i] + takeNums[i];
            }

            Console.WriteLine(result);
        }
    }
}

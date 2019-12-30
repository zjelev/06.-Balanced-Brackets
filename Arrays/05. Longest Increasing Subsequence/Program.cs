using System;
using System.Linq;

namespace _05._Longest_Increasing_Subsequence
{
    class Program1
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split(" ")
                .Select(int.Parse).ToArray();

            int[] len = new int[nums.Length];
            int[] prev = new int[nums.Length];

            int maxLen = 0;
            int lastIndex = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                len[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if ((nums[i] > nums[j]) && (len[j] + 1 > len[i]))
                    {
                        len[i] = len[j] + 1;
                        prev[i] = j;
                    }
                }
                if (len[i] > maxLen)
                {
                    maxLen = len[i];
                    lastIndex = i;
                }
            }

            int[] lis = new int[maxLen];

            for (int i = maxLen - 1; i >= 0; i--)
            {
                lis[i] = nums[lastIndex];
                lastIndex = prev[lastIndex];
            }
            
            Console.WriteLine(string.Join(" ", lis));
        }
    }
}
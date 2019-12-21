using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] incrSequence = new int[nums.Length - 1];

            int incrCount = 0;
            incrSequence[incrCount] = int.MaxValue;

            //7 3 5 8 - 1 0 6 7    
            //1 2 5 3 5 2 4 1 
            //0 10 20 30 30 40 1 50 2 3 4 5 6
            //11 12 13 3 14 4 15 5 6 7 8 7 16 9 8 
            //3 14 5 12 15 7 8 9 11 10 1 
            //3 5 

            int left = int.MaxValue;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] < nums[i + 1])
                {
                    incrSequence[incrCount] = nums[i];
                    left = nums[i];
                }
                else
                {
                    while (true)
                    {

                    }
                }
                
            }
            Console.WriteLine(string.Join(" ", incrSequence));
        }
    }
}

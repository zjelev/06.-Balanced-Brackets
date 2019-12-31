using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            string bombPower = Console.ReadLine();
            string[] bombAndPower = bombPower.Split(" ");
            int bombNum = int.Parse(bombAndPower[0]);
            int power = int.Parse(bombAndPower[1]);

            while (nums.Contains(bombNum))
            {
                int bombIndex = nums.IndexOf(bombNum);
                if (bombIndex + power > nums.Count)
                {
                    int powerToTheEnd = nums.Count - bombIndex - 1;
                    nums.RemoveRange(bombIndex + 1, powerToTheEnd);
                }
                else
                {
                    nums.RemoveRange(bombIndex + 1, power);
                }

                if (bombIndex - power < 0)
                {
                    nums.RemoveRange(0, bombIndex);
                }
                else
                {
                    nums.RemoveRange(bombIndex - power, power);
                }

                nums.Remove(bombNum);
            }

            int sum = 0;

            foreach (var item in nums)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}

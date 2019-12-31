//judge.softuni.bg/Contests/Practice/Index/1211#1

using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main()
        {
            List<int> nums= Console.ReadLine()
                .Split(" ")
                .Select(x => int.Parse(x))
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] commands = input.Split(" ");
                string firstComm = commands[0];
                int element = int.Parse(commands[1]);

                if (firstComm == "Delete")
                {
                    nums.RemoveAll(x => x == element );
                }
                else if (firstComm == "Insert")
                {
                    int position = int.Parse(commands[2]);
                    nums.Insert(position, element);
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}

//judge.softuni.bg/Contests/Practice/Index/1211#3

using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine()
                .Split(" ")
                .Select(x => int.Parse(x))
                .ToList();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] commands = input.Split(" ");
                string firstCommand = commands[0];

                switch (firstCommand)
                {
                    case "Add":
                        int number = int.Parse(commands[1]);
                        nums.Add(number);
                        break;
                    case "Insert":
                        number = int.Parse(commands[1]);
                        int index = int.Parse(commands[2]);
                        if (index >= nums.Count || index < 0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            nums.Insert(index, number);
                        }
                        break;
                    case "Remove":
                        index = int.Parse(commands[1]);
                        if (index >= nums.Count || index < 0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            nums.RemoveAt(index);
                        }
                        break;
                    case "Shift":
                        string direction = commands[1];
                        int count = int.Parse(commands[2]);
                        if (direction == "left")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                int temp = nums[0];
                                nums.RemoveAt(0);
                                nums.Add(temp);
                            }
                        }
                        else if (direction == "right")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                int temp = nums[nums.Count - 1];
                                for (int j = nums.Count - 2; j >= 0; j--)
                                {
                                    nums[j + 1] = nums[j];
                                }
                                nums[0] = temp;
                            }
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}

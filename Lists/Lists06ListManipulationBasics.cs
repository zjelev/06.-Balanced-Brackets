using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();
            bool isArrChanged = false;

            while (input != "end")
            {
                string[] commands = input.Split();
                string command = commands[0];


                if (command == "Add")
                {
                    nums.Add(int.Parse(commands[1]));
                    isArrChanged = true;
                }
                else if (command == "Remove")
                {
                    nums.Remove(int.Parse(commands[1]));
                    isArrChanged = true;
                }
                else if (command == "RemoveAt")
                {
                    nums.RemoveAt(int.Parse(commands[1]));
                    isArrChanged = true;
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(commands[2]);
                    nums.Insert(index, int.Parse(commands[1]));
                    isArrChanged = true;
                }

                if (command == "Filter")
                {
                    List<int> result = new List<int>();
                    switch (commands[1])
                    {
                        case ">=":
                            for (int i = 0; i < nums.Count; i++)
                            {
                                if (nums[i] >= int.Parse(commands[2]))
                                {
                                    result.Add(nums[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ", result));
                            break;
                        case "<=":
                            for (int i = 0; i < nums.Count; i++)
                            {
                                if (nums[i] <= int.Parse(commands[2]))
                                {
                                    result.Add(nums[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ", result));
                            break;
                        case ">":
                            for (int i = 0; i < nums.Count; i++)
                            {
                                if (nums[i] > int.Parse(commands[2]))
                                {
                                    result.Add(nums[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ", result));
                            break;
                        case "<":
                            for (int i = 0; i < nums.Count; i++)
                            {
                                if (nums[i] < int.Parse(commands[2]))
                                {
                                    result.Add(nums[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ", result));
                            break;
                    }
                }
                else if (command == "Contains")
                {
                    int argument = int.Parse(commands[1]);
                    bool contains = nums.Contains(argument);
                    if (contains)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else
                {
                    switch (command)
                    {
                        case "PrintEven":
                            List<int> result = new List<int>();
                            for (int i = 0; i < nums.Count; i++)
                            {
                                if (nums[i] % 2 == 0)
                                {
                                    result.Add(nums[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ", result));
                            break;
                        case "PrintOdd":
                            result = new List<int>();
                            for (int i = 0; i < nums.Count; i++)
                            {
                                if (nums[i] % 2 == 1)
                                {
                                    result.Add(nums[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ", result));
                            break;
                        case "GetSum":
                            int sum = 0;
                            for (int i = 0; i < nums.Count; i++)
                            {
                                sum += nums[i];
                            }
                            Console.WriteLine(sum);
                            break;

                        default:
                            break;
                    }
                }
                input = Console.ReadLine();
            }

            if (isArrChanged)
            {
                Console.WriteLine(string.Join(" ", nums));
            }

        }
    }
}

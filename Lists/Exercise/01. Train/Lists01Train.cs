//https://judge.softuni.bg/Contests/Practice/Index/1211#0

using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main()
        {
            List<int> wagons = Console.ReadLine()
                .Split(" ")
                .Select(x => int.Parse(x))
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] commands = input.Split(" ");

                if (commands[0] == "Add")
                {
                    wagons.Add(int.Parse(commands[1]));
                }
                else
                {
                    int passengers = int.Parse(commands[0]);
                    for (int i = 0; i < wagons.Count && passengers > 0; i++)
                    {
                        int spaceInWagon = maxCapacity - wagons[i];
                        if (spaceInWagon >= passengers)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                        //else
                        //{
                        //    wagons[i] += spaceInWagon;
                        //}
                        //passengers -= spaceInWagon;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
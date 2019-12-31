//https://judge.softuni.bg/Contests/Practice/Index/1211#2

using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main()
        {
            int commandsCount = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < commandsCount; i++)
            {
                string[] commands = Console.ReadLine().Split(" ");
                string name = commands[0];
                string isGoing = commands[2];

                if (isGoing == "going!")
                {
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");   
                    }
                    else
                    {
                        guests.Add(name);
                    }   
                }
                else if (isGoing == "not")
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            for (int i = 0; i < guests.Count; i++)
            {
                Console.WriteLine(guests[i]);
            }
        }
    }
}

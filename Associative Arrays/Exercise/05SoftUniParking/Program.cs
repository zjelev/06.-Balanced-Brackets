using System;
using System.Collections.Generic;
using System.Linq;

namespace _05SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var driversCars = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string command = input[0];
                string user = input[1];

                if (command == "register")
                {
                    string plateNum = input[2];
                    if (!driversCars.ContainsKey(user))
                    {
                        driversCars.Add(user, plateNum);
                        Console.WriteLine($"{user} registered {plateNum} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {driversCars[user]}");
                    }
                }
                else if (command == "unregister")
                {
                    if (driversCars.ContainsKey(user))
                    {
                        driversCars.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                }
            }
            
            Console.WriteLine(string.Join(Environment.NewLine, driversCars
            .Select(x => $"{x.Key} => {x.Value}")));
            
        }
    }
}

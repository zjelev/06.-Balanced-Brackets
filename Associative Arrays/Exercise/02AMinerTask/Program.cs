using System;
using System.Collections.Generic;
using System.Linq;

namespace _02AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            var resources = new Dictionary<string, int>();
            while(resource != "stop")
            {
                if (!resources.ContainsKey(resource))
                {
                    resources.Add(resource, 0);
                }
                int quantity = int.Parse(Console.ReadLine());
                resources[resource] += quantity;
                resource = Console.ReadLine();
            }

            foreach (var kvp in resources)
            {
                System.Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}

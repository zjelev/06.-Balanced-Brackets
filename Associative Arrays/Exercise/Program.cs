using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
{
    class Program
    {
        static void Main() /* => 
            Console.ReadLine()
            .Split()
            .Where(w => w.Length % 2 == 0)
            .OrderByDescending(x => x.Length)
            .ThenBy(x => x)
            .ToList()
            .ForEach(Console.WriteLine);
        
        {
            var dict = new Dictionary<string, int>
            {
                ["Ivan"] = 5,
                ["Ana"] = 6,
                ["Peter"] = 3,
                ["Maria"] = 6
            };

            var result = dict
            .Where(kvp => kvp.Value == 6)
            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            System.Console.WriteLine(result["Ana"]);
        }
        
        =>  Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .OrderByDescending(x => x)
            .Take(3)
            .ToList()
            .ForEach(x => Console.Write(x + " ")); */
            {
                var text = Console.ReadLine()
                .Where(x => x != ' ')
                .ToList();

                //text.ForEach(Console.WriteLine);
                var occurrences = new Dictionary<char, int>();
                foreach (var character in text)
                {
                    if (occurrences.ContainsKey(character) == false)
                    {
                        occurrences[character] = 0;
                    }
                    
                    occurrences[character]++;
                }

                foreach (var item in occurrences)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
    }
}

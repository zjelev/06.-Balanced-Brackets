using System;
using System.Collections.Generic;
using System.Linq;

namespace _03LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyMat = new Dictionary<string, int>();
            keyMat["shards"] = 0;
            keyMat["fragments"] = 0;
            keyMat["motes"] = 0;
            var junkMat = new SortedDictionary<string, int>();
            bool hasToBreak = false;
            string legendaryItem = String.Empty;

            while (!hasToBreak)
            {
                string[] input = Console.ReadLine().ToLower().Split(' ');
                
                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1];

                    if (keyMat.ContainsKey(material))
                    {
                        keyMat[material] += quantity;
                        
                        if (keyMat[material] >= 250)
                        {
                            if (material == "shards")
                            {
                                legendaryItem = "Shadowmourne";
                            }
                            else if (material == "fragments")
                            {
                                legendaryItem = "Valanyr";
                            }
                            else
                            {
                                legendaryItem = "Dragonwrath";
                            }
                            keyMat[material] -= 250;
                            hasToBreak = true;
                            Console.WriteLine($"{legendaryItem} obtained!");
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMat.ContainsKey(material))
                        {

                            junkMat.Add(material, 0);
                        }
                        junkMat[material] += quantity;
                    }
                }
            }

            keyMat = keyMat.OrderByDescending(x => x.Value)
            .ThenBy(x => x.Key)
            .ToDictionary(a => a.Key, a => a.Value);

            foreach (var item in keyMat)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junkMat)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
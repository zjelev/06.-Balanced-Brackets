using System;
using System.Collections.Generic;
using System.Linq;

namespace _09ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var sideMembers = new Dictionary<string, List<string>>();
            bool memberExists = false;
            string memberOf = String.Empty;

            while (input != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    string[] splittedInput = input.Split(" | ");
                    string side = splittedInput[0];
                    string member = splittedInput[1];
                    
                    if (!sideMembers.ContainsKey(side))
                        {
                            sideMembers[side] = new List<string>();
                        }

                    foreach (var kvp in sideMembers)
                    {
                        if (kvp.Value.Contains(member))
                        {
                            memberExists = true;
                            memberOf = kvp.Key;
                            break;
                        }
                    }

                    if (!sideMembers[side].Contains(member) && !memberExists) 
                    {
                        sideMembers[side].Add(member);
                    }
                }
                else if (input.Contains("->"))
                {
                    string[] splittedInput = input.Split(" -> ");
                    string member = splittedInput[0];
                    string side = splittedInput[1];

                    if (!sideMembers.ContainsKey(side))
                        {
                            sideMembers[side] = new List<string>();
                        }
                    
                    foreach (var kvp in sideMembers)
                    {
                        if (kvp.Value.Contains(member))
                        {
                            memberExists = true;
                            memberOf = kvp.Key;
                            break;
                        }
                    }

                    if (memberExists)
                        {
                            sideMembers[memberOf].Remove(member);
                        }

                    sideMembers[side].Add(member);
                    Console.WriteLine($"{member} joins the {side} side!");
                }
                
                input = Console.ReadLine();
                
                if (input == "Lumpawaroo")
                {
                    break;
                }
            }

            sideMembers = sideMembers.Where(x => x.Value.Count > 0)
            .OrderByDescending(x => x.Value.Count)
            .ThenBy(x => x.Key)
            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var kvp in sideMembers)
            {
                Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");               
                Console.WriteLine("! " + string.Join("\n! ", kvp.Value.OrderBy(x => x)));
            }
        }
    }
}
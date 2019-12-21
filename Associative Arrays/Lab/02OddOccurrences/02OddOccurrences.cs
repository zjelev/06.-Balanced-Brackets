using System;
using System.Collections.Generic;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();
            
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();
                if (!synonyms.ContainsKey(word))
                {
                    synonyms[word] = new List<string>();
                }
                
                synonyms[word].Add(synonim);
            }
            foreach (var item in synonyms)
            {
                var synonymsOfWord = item.Value;

                System.Console.WriteLine($"{item.Key} - {string.Join(", ", synonymsOfWord)}");
            }
        }
    }
}
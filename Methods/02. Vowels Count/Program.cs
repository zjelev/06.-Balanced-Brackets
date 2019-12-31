using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine().ToLower();
            Console.WriteLine(CountCommon("aeiou", name));
        }

        private static int CountCommon(string letters, string toCheck)
        {
            int countCommon = 0;

            for (int i = 0; i < toCheck.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (letters[j] == toCheck[i])
                    {
                        countCommon++;
                    }
                }
            }

            return countCommon;
        }
    }
}

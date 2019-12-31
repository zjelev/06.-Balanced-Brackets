using System;

namespace _02._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');

            var rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int randIndex = rnd.Next(words.Length);

                string temp = words[i];

                words[i] = words[randIndex];

                words[randIndex] = temp;
            }

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}

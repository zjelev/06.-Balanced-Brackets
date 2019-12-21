using System;
using System.Linq;
//test github

namespace _02.Pascal_Triangle
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] line = new int[n];
            int[] nextLine = new int[n];

            line[0] = 1;
            nextLine[0] = 1;

            for (int i = 1; i <= n; i++)
            {
                line[i-1] = 1;
                nextLine[i-1] = 1;

                for (int j = 1; j < i - 1; j++)
                {
                    nextLine[j] = line[j - 1] + line[j];
                }
                
                for (int j = 0; j < i; j++)
                {
                    Console.Write(nextLine[j] + " ");
                    line[j] = nextLine[j];
                }

                Console.WriteLine();
            }
        }
    }
}

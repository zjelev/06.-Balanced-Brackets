using System;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());

            string[] firstArr = new string[linesCount];
            string[] secondArr = new string[linesCount];

            for (int i = 0; i < linesCount; i++)
            {
                string[] currentLine = Console.ReadLine().Split(" ");

                if (i%2==0)
                {
                    firstArr[i] = currentLine[0];
                    secondArr[i] = currentLine[1];
                }
                else
                {
                    secondArr[i] = currentLine[0];
                    firstArr[i] = currentLine[1];
                }
            }
            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));
        }
    }
}

using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main()
        {
            string[] firstArray = Console.ReadLine()
                .Split(" ");

            string[] secondArray = Console.ReadLine()
                .Split(" ");

            for (int i = 0; i < secondArray.Length; i++)
            {
                if (firstArray.Contains(secondArray[i]))
                {
                    Console.Write(secondArray[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

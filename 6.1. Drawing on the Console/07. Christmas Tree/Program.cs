using System;

namespace _07._Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 0; row <= n; row++)
            {
                for (int col = 0; col < n - row; col++)
                {
                    Console.Write(" ");
                }
                
                for (int col = 0; col < row; col++)
                {
                    Console.Write("*");
                }
                Console.Write(" | ");
                for (int col = 0; col < row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
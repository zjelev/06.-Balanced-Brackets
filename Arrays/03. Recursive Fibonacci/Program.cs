using System;

namespace _03._Recursive_Fibonacci
//Non-recursive, Array
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] fibonacci = new int[n];
            fibonacci[0] = 1;

            if (n>1)
            {
                fibonacci[1] = 1;

                for (int i = 2; i < n; i++)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
            }
            Console.WriteLine(fibonacci[n - 1]);
        }
    }
}

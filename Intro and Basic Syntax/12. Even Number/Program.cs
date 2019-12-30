using System;

namespace _12._Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            while (a % 2 != 0)
            {
                a = int.Parse(Console.ReadLine());
                if (a % 2 != 0)
                {
                    Console.WriteLine("Please write an even number.");
                }
                else
                {
                    Console.WriteLine("The number is: " + Math.Abs(a));
                }
            }
        }
    }
}
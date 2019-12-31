using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                PrintLine(number);  
            }
        }

        static void PrintLine(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}

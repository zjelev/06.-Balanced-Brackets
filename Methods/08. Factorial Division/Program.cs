using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            double result = (double)Factorial(first) / Factorial(second);
            Console.WriteLine($"{result:f2}");
        }

        static long Factorial(int number)
        {

            long fact = 1;

            for (int i = 2; i <= number; i++)
            {
                fact *= i;
            }

            return fact;
           
        }
    }
}

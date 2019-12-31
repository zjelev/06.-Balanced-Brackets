using System;
using System.Numerics;

namespace _03._Big_Factorial
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger fact = new BigInteger(1);

            for (int i = 2; i <= n; i++)
            {
                fact *= i; 
            }

            Console.WriteLine(fact);
        }
    }
}
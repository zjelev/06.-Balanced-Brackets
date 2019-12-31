using System;
using System.Numerics;

namespace _04._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger cnt = BigInteger.Parse(Console.ReadLine());
            BigInteger days = cnt * 3652422 / 100;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", cnt, 
                cnt * 100, days, days * 24, days * 24 * 60);
        }
    }
}
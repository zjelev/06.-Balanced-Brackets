using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int cap = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Ceiling(n / cap));
        }
    }
}
using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
            if (times <=10)
            {
                for (int i = times; i < 11; i++)
                {
                    Console.WriteLine("{0} X {1} = {2}", a, i, a * i);
                }
            }
            else
            {
                Console.WriteLine("{0} X {1} = {2}", a, times, a * times);
            }
        }
    }
}
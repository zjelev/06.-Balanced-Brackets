using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine(Subtract(Sum(first, second), third)); 
        }

        static int Sum(int first, int second)
        {
            return first + second;
        }

        static int Subtract(int first, int second)
        {
            return first - second;
        }

    }
}

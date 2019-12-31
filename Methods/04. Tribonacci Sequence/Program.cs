using System;

namespace _04._Tribonacci_Sequence
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            int first = 0;
            int second = 1;
            int third = first + second;

            if (num < 2)
            {
                Console.WriteLine(second);  
            }
            else
            {
                Console.Write(second + " " + third);
                for (int i = 2; i < num; i++)
                {
                    int fourth = first + second + third;
                    Console.Write(" " + fourth);
                    first = second;
                    second = third;
                    third = fourth;
                }
            }

            Console.WriteLine();
        }
    }
}

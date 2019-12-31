using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main()
        {
            char begin = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            if (begin < end)
            {
                PrintCharsBetween(begin, end);
                return;
            }
                PrintCharsBetween(end, begin);
        }

        private static void PrintCharsBetween(char begin, char end)
        {
            for (int i = begin + 1; i < end; i++)
            {
                Console.Write((char)i + " ");
            }

            Console.WriteLine();
        }
    }
}

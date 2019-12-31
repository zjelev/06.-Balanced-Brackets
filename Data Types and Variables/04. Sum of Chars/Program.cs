using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (char i = (char)start; i <= (char)end; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
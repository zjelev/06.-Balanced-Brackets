using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        private static void Main()
        {
            int n = 3; // int.Parse(Console.ReadLine());
            //int smallestNum = int.MaxValue;
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                //int number = int.Parse(Console.ReadLine());
                //smallestNum = ReturnSmallest(number, smallestNum);

                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(ReturnSmallest(numbers));
        }

        private static int ReturnSmallest(int a, int b) => a > b ? b : a;

        private static int ReturnSmallest(int[] numbers)
        {
            int smallestNum = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                smallestNum = ReturnSmallest(numbers[i], smallestNum);
            }

            return smallestNum;
        }
    }
}
using System;

namespace I._Declaring_and_Invoking_Methods
{
    class Program
    {
        //static void PrintNumbers(int start, int end = 500)
        //{
        //    for (int i = start; i <= end; i++)
        //    {
        //        Console.Write(i + " ");
        //    }
        //    Console.WriteLine();
        //}
        //
        //static void DoubleNumber(int number)
        //{
        //    number *= 2; ;
        //}
        //

        //
        //// struct => value type /стойностен тип /
        //// class => reference type
        //
        //static void ChangeName(string name)
        //{
        //    name += " Peshev";
        //}
        //
        //static void ChangeArray(int[] arr)
        //{
        //    arr[0] *= 2;
        //}

        static void Main()
        {
            //    //PrintNumbers(50, end: 100);
            //    int numToDouble = int.Parse(Console.ReadLine());
            //    DoubleNumber(numToDouble);
            //    Console.WriteLine("Number not changed: " + numToDouble);
            //
            //    string name = Console.ReadLine();
            //    ChangeName(name);
            //    Console.WriteLine("Name not changed: " + name);
            //
            //    int[] array = new int[10];
            //    array[0] = int.Parse(Console.ReadLine());
            //    ChangeArray(array);
            //    Console.WriteLine("Array changes: " + array[0]);
            //
            //

            int number = Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            number = Math.Abs(number);

            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);
            int result = evenSum * oddSum;
            return result;
        }

        static int GetSumOfEvenDigits(int number)
        {
            int result = 0;
            while (number > 0)
            {
                int currentDigit = number % 10;
                if (currentDigit % 2 == 0)
                {
                    result += currentDigit;
                }
                number /= 10;
            }
            return result;
        }

        static int GetSumOfOddDigits(int number)
        {
            int result = 0;
            while (number > 0)
            {
                int currentDigit = number % 10;
                if (currentDigit % 2 != 0)
                {
                    result += currentDigit;
                }
                number /= 10;
            }
            return result;
        }
    }
}

using System;

namespace _05._Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            //int multipliedThree = Multiply(Multiply(num1, num2), num3);
            int multipliedThree = FindSignOfMultiplication(FindSignOfMultiplication(num1, num2), num3);

            if (multipliedThree > 0)
            {
                Console.WriteLine("positive");
            }
            else if (multipliedThree < 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("zero");
            }
        }

        //private static int Multiply(int num1, int num2)
        //{
        //    int multiply = 0;
        //
        //    if (num2 > 0)
        //    {
        //        for (int i = 0; i < num2; i++)
        //        {
        //            multiply += num1;
        //        }
        //    }
        //    else if (num2 < 0)
        //    {
        //        for (int i = 0; i > num2; i--)
        //        {
        //            multiply -= num1;
        //        }
        //    }
        //
        //    return multiply;
        //}

        private static sbyte FindSignOfMultiplication(int num1, int num2)
        {
            if (num1 == 0 || num2 == 0)
            {
                return 0;
            }
            else if (num1 > 0 && num2 > 0 || num1 < 0 && num2 < 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}

using System;

namespace _06._Strong_number
{
    class Program
    {
        static int Factorial(int n)
        { 
            int result = 1;
            for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
            return result;
        }
        /*public static int NumberOfDigits(int n)
        {
            int digits = 0;
            do
            {
                ++digits;
                n /= 10;
            } while (n != 0);
            return digits;
        }
        static int[] Digits(int n)
        {
            int[] digits = new int[NumberOfDigits(n)];
            int temp = 0;
            for (int i = NumberOfDigits(n) - 1; i >= 0 ; i--)
            {
                temp = n % 10;
                digits[i] = temp;
                n = n / 10;
            }
            return digits;
        }*/
        static int sumFactDigits(int n)
        {
            int temp = 0, sum = 0;
            while (n>0)
            {
                temp = n % 10;
                sum += Factorial(temp);
                n = n / 10;
            }
            return sum;
        }
            static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            /*Console.WriteLine(Factorial(number));
            for (int i = 0; i < NumberOfDigits(number); i++)
            {
                Console.Write(Digits(number)[i] + " ");
            }*/
            /*int sumFactDigits = 0;
            for (int i = 0; i < NumberOfDigits(number); i++)
            {
                sumFactDigits += Factorial(Digits(number)[i]);
            }*/
            if (sumFactDigits(number) == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (IsSumOfDigitsDivBy8(i) && HasOneOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsSumOfDigitsDivBy8(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int currentDigit = number % 10;
                sum += currentDigit;
                number /= 10;
            }

            if (sum % 8 == 0)
            {
                return true;
            }

            return false;
        }

        static bool HasOneOddDigit(int number)
        {
            while (number > 0)
            {
                int currentDigit = number % 10;
                if (currentDigit % 2 == 1)
                {
                    return true;
                }
                number /= 10;
            }

            return false;
        }
    }
}

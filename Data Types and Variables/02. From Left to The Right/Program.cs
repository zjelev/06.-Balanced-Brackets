using System;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string num1 = null;
                 
                for (int j = 0; j < line.Length; j++)
                {
                    if (line[j] != ' ')
                    {
                        num1 += line[j];
                    }
                    else
                    {
                        break;
                    }
                }

                string reverseNum2 = null;
                for (int j = line.Length - 1; j >= 0 ; j--)
                {
                    if (line[j] != ' ')
                    {
                        reverseNum2 += line[j];
                    }
                    else
                    {
                        break;
                    }
                }

                string num2 = null;
                for (int j = reverseNum2.Length - 1; j >= 0; j--)
                {
                    num2 += reverseNum2[j];
                }

                long number1 = long.Parse(num1);
                long number2 = long.Parse(num2);
                long sumDigits = 0;

                if (number1 > number2)
                {
                    while (number1 != 0)
                    {
                        sumDigits += number1 % 10;
                        number1 /= 10;
                    }
                }
                else
                {
                    while (number2 != 0)
                    {
                        sumDigits += number2 % 10;
                        number2 /= 10;
                    }
                }

                Console.WriteLine(Math.Abs(sumDigits));
            }
        }
    }
}
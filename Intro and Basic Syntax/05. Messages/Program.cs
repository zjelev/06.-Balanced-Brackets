using System;

namespace _05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int textLenght = int.Parse(Console.ReadLine());
            for (int i = 0; i < textLenght; i++)
            {
                int letter = int.Parse(Console.ReadLine());
                int mainDigit = 0, temp = letter, numberOfDigits = 1;
                if (letter < 10)
                {
                    mainDigit = letter;
                }
                else
                {
                    do
                    {
                        mainDigit = temp / 10;
                        temp = mainDigit;
                        numberOfDigits++;
                    } while (mainDigit >= 10) ;
                }
                //Console.WriteLine(mainDigit + " " + numberOfDigits);
                int offset = (mainDigit - 2) * 3;
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset++;
                }
                int letterIndex = offset + numberOfDigits - 1;
                if (mainDigit == 0)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write((char)(letterIndex + 97));
                }
            }
        }
    }
}
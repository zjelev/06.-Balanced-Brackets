using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            Console.WriteLine(PrintMiddleChars(text));
            
        }

        static string PrintMiddleChars(string text)
        {
            string middleChars = text[text.Length / 2].ToString();

            if (text.Length % 2 == 1)
            {
                return middleChars;
            }

            middleChars = text[text.Length / 2 - 1].ToString() + text[text.Length / 2];

            return middleChars;
        }
    }
}

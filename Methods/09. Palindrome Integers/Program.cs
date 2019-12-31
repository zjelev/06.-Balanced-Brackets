using System;
using System.Linq;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                Console.WriteLine(IsItPalindrome(input));
                input = Console.ReadLine();
            }
        }

        static string IsItPalindrome(string numberToString)
        {
            char[] charArray = numberToString.ToCharArray();
            Array.Reverse(charArray);
            string reversed = string.Join("", charArray);
            if (numberToString == reversed)
            {
                return "true";
            }

            return "false";
        }
    }
}

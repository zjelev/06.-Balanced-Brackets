using System;

namespace _06._Balanced_Brackets
{
    class BalancedBrackets
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            bool betweenBrackets = false;
            bool openBracket = false;
            bool closedBracket = false;
            bool balanced = true;
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                if (!betweenBrackets && line == "(")
                {
                    openBracket = true;
                    betweenBrackets = true;
                }
                else if (betweenBrackets && line == "(")
                {
                    balanced = false;
                }
                if (betweenBrackets && line == ")")
                {
                    openBracket = false;
                    closedBracket = true;
                    betweenBrackets = false;
                }
                else if (!betweenBrackets && line == ")")
                {
                    balanced = false;
                }
            }
            Console.WriteLine(!openBracket && !betweenBrackets && closedBracket && balanced ? "BALANCED" : "UNBALANCED");
        }
    }
}

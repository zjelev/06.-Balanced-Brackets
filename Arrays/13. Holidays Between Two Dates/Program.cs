using System;
using System.Linq;

namespace _13._Holidays_Between_Two_Dates
{
    class Program
    {
        static void Main()
        {
            //int[] arr = Console.ReadLine()
            //.Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //.Select(int.Parse)
            //.ToArray();
            //
            

            int[] secondArr = new int[5];

            int arrayIndex = 0;
            
            string[] splitedInput = Console.ReadLine().
                Split(" ");

            for (int j = 0; j < splitedInput.Length; j++)
            {
                if (splitedInput[j] != "" && arrayIndex < secondArr.Length)
                {
                    int number = int.Parse(splitedInput[j]);
                    secondArr[arrayIndex] = number;
                    arrayIndex++;
                }
            }

            Console.WriteLine(string.Join(", ", secondArr));
        }
    }
}

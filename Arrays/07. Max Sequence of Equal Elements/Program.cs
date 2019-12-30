using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(" ")
                .Select(int.Parse)
                .ToArray();

            int longestSequenceCount = 1;
            int currentSequenceCount = 1;

            int numberOfLongestSequence = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i-1])
                {
                    currentSequenceCount++;

                    if (currentSequenceCount > longestSequenceCount)
                    {
                        longestSequenceCount = currentSequenceCount;
                        numberOfLongestSequence = numbers[i];
                    }
                }
                else
                {
                    currentSequenceCount = 1;
                }
            }

            for (int i = 0; i < longestSequenceCount; i++)
            {
                Console.Write(numberOfLongestSequence + " ");
            }
        }
    }
}

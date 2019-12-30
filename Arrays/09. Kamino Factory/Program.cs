using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main()
        {
            int dnaLength = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            int maxCountOnes = 0;
            int maxArraySum = 0;

            int[] bestArray = new int[dnaLength];

            while (command != Console.ReadLine())
            {
                int[] currentArr = command.Split("!")
                    .Select(int.Parse)
                    .ToArray();

                int countOnes = 0;
                int startingIndex = int.MaxValue;
                
                int currentArraySum = 0;
                

                for (int i = 1; i <= currentArr.Length; i++)
                {
                    
                    if (currentArr[i - 1] == 1)
                    {
                        countOnes++;
                        if (currentArr[i] == 1)
                        {
                            countOnes++;
                            startingIndex = i - countOnes;
                        }
                        else
                        {
                            countOnes = 0;
                            startingIndex = int.MaxValue;
                        }
                    }

                    currentArraySum += currentArr[i - 1];
                }

                if (countOnes > maxCountOnes)
                {
                    maxCountOnes = countOnes;
                    bestArray = currentArr;
                }

                if (currentArraySum > maxArraySum)
                {
                    maxArraySum = currentArraySum;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample 2 with sum: {maxCountOnes}");
            Console.WriteLine(string.Join(" ", bestArray));
        }
    }
}

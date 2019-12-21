using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main()
        {
            int[] arrOfInt = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandToArr = command.Split(" ");
                string firstCommand = commandToArr[0];

                if (firstCommand == "exchange")
                {
                    int exchangeIndex = int.Parse(commandToArr[1]);
                    if (exchangeIndex >= arrOfInt.Length || exchangeIndex < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        Exchange(arrOfInt, exchangeIndex);
                    }
                }

                else if (firstCommand == "max" || firstCommand == "min")
                {
                    Console.WriteLine(EvenOddMaxMin(arrOfInt, firstCommand, commandToArr[1]));
                }

                else if (firstCommand == "first" || firstCommand == "last")
                {
                    int count = int.Parse(commandToArr[1]);

                    if (count > arrOfInt.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        Console.WriteLine("[" + FirstLast(EvenOrOdd(arrOfInt, commandToArr[2]), 
                            firstCommand, count) + "]");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", arrOfInt) + "]");
        }

        static void Exchange(int[] arr, int index)
        {
            int[] exchangedArr = new int[arr.Length];
            int indexExchArr = 0;

            for (int i = index + 1; i < arr.Length; i++)
            {
                exchangedArr[indexExchArr] = arr[i];
                indexExchArr++;
            }

            for (int i = 0; i <= index; i++)
            {
                exchangedArr[indexExchArr] = arr[i];
                indexExchArr++;
            }

            Array.Copy(exchangedArr, arr, arr.Length);
        }

        static string EvenOddMaxMin(int[] arr, string maxMin, string evenOdd)
        {
            int index = -1;
            int max = int.MinValue;
            int min = int.MaxValue;

            int resultFromModDiv = 0;
            if (evenOdd == "odd")
            {
                resultFromModDiv = 1;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == resultFromModDiv)
                {
                    if (maxMin == "min")
                    {
                        if (arr[i] <= min)
                        {
                            index = i;
                            min = arr[i];
                        }
                    }
                    else if (maxMin == "max")
                    {
                        if (arr[i] >= max)
                        {
                            index = i;
                            max = arr[i];
                        }
                    }
                }
            }

            if (index >= 0)
            {
                return index.ToString();
            }

            return "No matches";
        }

        static int[] EvenOrOdd(int[] arr, string evenOdd)
        {
            int[] evenOrOdd = new int[arr.Length];
            int index = 0;

            int resultFromModDiv = 0;
            if (evenOdd == "odd")
            {
                resultFromModDiv = 1;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == resultFromModDiv)
                {
                    evenOrOdd[index] = arr[i];
                    index++;
                }
            }

            arr = new int[index];
            Array.Copy(evenOrOdd, arr, index);

            return arr;
        }

        static string FirstLast(int[] arr, string firstLast, int count)
        {
            int[] newArr = new int[arr.Length];
            int index = 0;

            if (firstLast == "first")
            {
                for (int i = 0; i < count && i < arr.Length; i++)
                {
                    newArr[i] = arr[i];
                    index++;
                }
            }
            else if (firstLast == "last")
            {
                for (int i = arr.Length - 1; i >= 0 && i >= arr.Length - count; i--)
                {
                    newArr[arr.Length - i - 1] = arr[i];
                    index++;
                }
                newArr.Reverse();
            }

            arr = new int[index];

            Array.Copy(newArr, arr, index);

            return string.Join(", ", arr);
        }
    }
}
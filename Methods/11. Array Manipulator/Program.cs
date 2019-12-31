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

                if (commandToArr[0] == "exchange")
                {
                    Exchange(arrOfInt, int.Parse(commandToArr[1]));
                    //Console.WriteLine(string.Join(" ", arrOfInt));
                }

                else if (commandToArr[0] == "max" || commandToArr[0] == "min")
                {
                    Console.WriteLine(EvenOddMaxMin(arrOfInt, commandToArr[0], commandToArr[1]));
                }

                else if (commandToArr[0] == "first" || commandToArr[0] == "last")
                {
                    string evenOrOddString = EvenOrOdd(arrOfInt, commandToArr[2]);

                    int count = int.Parse(commandToArr[1]);

                    int[] evenOrOdd = evenOrOddString.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse).ToArray();

                    Console.WriteLine("[" + FirstLast(evenOrOdd, commandToArr[0], count) + "]");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", arrOfInt) + "]");
        }

        static string Exchange(int[] arr, int index)
        {
            int[] exchangedArr = new int[arr.Length];
            int indexExchArr = 0;
            if (index < arr.Length && index >= 0)
            {
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

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = exchangedArr[i];
                }

                return string.Join(" ", arr);
            }

            return "Invalid index";
        }

        static string EvenOddMaxMin(int[] arr, string maxMin, string evenOdd)
        {
            int index = -1;
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (evenOdd == "odd")
                {
                    if (arr[i] % 2 != 0)
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
                else
                {
                    if (arr[i] % 2 == 0)
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
            }

            if (index >= 0)
            {
                return index.ToString();
            }

            return "No matches";

        }

        static string EvenOrOdd(int[] arr, string evenOdd)
        {
            int[] even = new int[arr.Length];
            int[] odd = new int[arr.Length];

            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even[index] = arr[i];
                    index++;
                }
                else
                {
                    odd[index] = arr[i];
                    index++;
                }
            }

            if (evenOdd == "even")
            {
                return string.Join(" ", even);
            }

            return string.Join(" ", odd);
        }

        //for (int i = 0; i < arr.Length; i++)
        //{
        //    arr[i] = evenOrOdd[i];
        //}

        static string FirstLast(int[] arr, string firstLast, int count)
        {
            int[] newArr = new int[count];

            if (count < arr.Length)
            {
                if (firstLast == "first")
                {
                    for (int i = 0; i < count; i++)
                    {
                        newArr[i] = arr[i];
                    }
                }
                else
                {
                    for (int i = arr.Length - count; i < arr.Length; i++)
                    {
                        newArr[i - arr.Length + count] = arr[i];
                    }
                }

                return string.Join(", ", newArr);
            }

            return "Invalid count";

        }
    }
}

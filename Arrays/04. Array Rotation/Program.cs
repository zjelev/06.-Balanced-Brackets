using System;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main()
        {
            string[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int numberOfRotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRotations % arr.Length; i++)
            {
                string first = arr[0];

                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }

                arr[arr.Length - 1] = first;
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}

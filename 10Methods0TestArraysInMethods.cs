using System;

namespace TestArraysInMethods
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            TestArr(arr);
            Console.WriteLine(arr[0]);
        }

        static void TestArr(int[] arr1)
        {
            arr1[0] = arr1[3];
        }
    }
}

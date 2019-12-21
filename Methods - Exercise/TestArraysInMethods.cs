using System;

namespace TestArraysInMethods
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };

            //Console.WriteLine(string.Join(" ", arr));
            //
            //Console.WriteLine(string.Join(" ", TestArr(arr)));
            //
            //Console.WriteLine(string.Join(" ", arr));

            int[] newarr = new int[arr.Length];

            newarr[0] = 100;

            Array.Copy(newarr, arr, arr.Length);

            Console.WriteLine(arr[0]);
        }

        static int[] TestArr(int[] arr)
        {

            arr = new int[arr.Length];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = 0;
            //}

            return arr;
        }
    }
}

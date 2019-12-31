using System;
//using System.Collections.Generic;
//using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main()
        {
            string[] arr = Console.ReadLine().Split("|");
            Array.Reverse(arr);
            string arrReversed = string.Join(" ", arr);
            string[] arrRemovedEmpty = arrReversed.Split(" ", StringSplitOptions.RemoveEmptyEntries); 
            Console.WriteLine(string.Join(" ", arrRemovedEmpty));
        }
    }
}
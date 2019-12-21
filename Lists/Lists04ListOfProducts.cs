using System;
using System.Collections.Generic;
using System.Globalization;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main()
        {
            //int n = int.Parse(Console.ReadLine());
            //
            //List<string> products = new List<string>();
            //
            //for (int i = 0; i < n; i++)
            //{
            //    string currentProduct = Console.ReadLine();
            //    products.Add(currentProduct);
            //}
            //
            //products.Sort();
            //
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"{i+1}.{products[i]}");
            //}

            List<int> products = new List<int>();

            for (int i = 0; i < 10000000; i++)
            {
                products.Add(i);
            }

            //var f = new NumberFormatInfo { NumberGroupSeparator = " " };
            //
            //var s = products.Count.ToString("n", f); // 2 000 000.00

            Console.WriteLine(string.Format($"{products.Count:N}"));

            for (int i = 0; i < 1000; i++)
            {
                products.Remove(products[products.Count - 1]);
            }

            Console.WriteLine(string.Format($"{products.Count:N}"));


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Stop_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=0, m=0, s=0;
            do
            {
               n = int.Parse(Console.ReadLine());
            }
            while (n < 0 || n > 9999);
            do
            {
                m = int.Parse(Console.ReadLine());
            }
            while (m < n || m > 10000);
            do
            {
                s = int.Parse(Console.ReadLine());
            } while (s < n || s > m);
            for (int i = m; i >= n; i--)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    if (i == s)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}
using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main()
        {
            int numberOfWagons = int.Parse(Console.ReadLine());

            int[] train = new int[numberOfWagons];
            int sum = 0;

            for (int i = 0; i < train.Length; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
                sum += train[i];
            }

            //int sum = train.Sum();
            //
            //Console.WriteLine(string.Join(" ", train));

            for (int i = 0; i < train.Length - 1; i++)
            {
                Console.Write(train[i] + " ");
            }

            Console.WriteLine(train[train.Length-1]);

            Console.WriteLine(sum);
        }
    }
}

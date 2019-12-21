using System;
using System.Linq;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int stringsNum = int.Parse(Console.ReadLine());

            string vowels = "AaEeIiOoUu";

            int[] encryptedArr = new int[stringsNum];

            for (int i = 0; i < stringsNum; i++)
            {
                string name = Console.ReadLine();

                for (int j = 0; j < name.Length; j++)
                {
                    if (vowels.Contains(name[j]))
                    {
                        encryptedArr[i] += name[j] * name.Length;
                    }
                    else
                    {
                        encryptedArr[i] += name[j] / name.Length;
                    }
                }
            }

            Array.Sort(encryptedArr);

            for (int i = 0; i < stringsNum; i++)
            {
                Console.WriteLine(encryptedArr[i]);
            }
        }
    }
}

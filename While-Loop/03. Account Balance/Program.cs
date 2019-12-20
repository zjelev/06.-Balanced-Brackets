using System;

namespace _03.Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int depositCount = int.Parse(Console.ReadLine());
            double balance = 0;
            while (depositCount > 0)
            {
                double deposit = double.Parse(Console.ReadLine());
                if (deposit > 0)
                {
                    Console.WriteLine($"Increase: {deposit:f2}");
                    balance += deposit;
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                depositCount--;
            }
            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}

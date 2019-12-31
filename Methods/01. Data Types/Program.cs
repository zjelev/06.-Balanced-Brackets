using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string arg = Console.ReadLine();

            if (input == "int")
            {
                int convertArg = int.Parse(arg);
                Process(convertArg);
            }
            else if (input == "real")
            {
                double convertArg = double.Parse(arg);
                Process(convertArg);
            }
            else
            {
                Process(arg);
            }
            
        }

        private static void Process(string arg)
        {
            Console.WriteLine("$" + arg + "$");
        }

        private static void Process(double arg)
        {
            
            Console.WriteLine($"{arg * 1.5:f2}");
        }

        private static void Process(int arg)
        {
            
            Console.WriteLine(arg * 2);
        }
    }
}

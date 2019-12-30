using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //float           a = 123456789012345678901234567890f; //30 digits
            //Console.WriteLine("{0:0.00000000000}", a/100000000000000000000000f);  // 1.234568E+29
            // Declare some variables
            //float floatPI = 3.141592653589793238f;
            //double doublePI = 3.141592653589793238;
            // Print the results on the console
            //Console.WriteLine("Float PI is: " + floatPI);
            //Console.WriteLine("Double PI is: " + doublePI);
            // Console output:
            // Float PI is: 3.141593

            //page 152
            byte x = 5;
            byte y = 3;
            //x *= y; // Same as x = x * y;
            Console.WriteLine(x | y); // 8
            // Double PI is: 3.14159265358979
            
            int a = 6;
            int b = 4;
            Console.WriteLine(a > b ? "a>b" : "b<=a"); // a>b
            int num = a == b ? 1 : -1; // num will have value -1

            Console.WriteLine(DateTime.Now);

            string sum = "Sum=" + a + b;
            Console.WriteLine(sum);
        }
    }
}

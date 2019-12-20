using System;

namespace _13.Notifications
{
    class Program
    {
        static void ShowSuccessMessage(string operation, string message)
        {
            Console.WriteLine("Successfully executed " + operation + ".");
            Console.WriteLine("======================" + new string('=', operation.Length) + "=");
            //Console.WriteLine("==============================");
            Console.WriteLine("Message: " + message + ".");
            Console.WriteLine();
        }

        static void ShowWarningMessage(string message)
        {
            Console.WriteLine("Warning: " + message + ".");
            Console.WriteLine("=========" + new string('=', message.Length) + "=");
            //Console.WriteLine("==============================");
            Console.WriteLine();
        }

        static void ShowErrorMessage(string operation, string message, int errorCode)
        {
            Console.WriteLine("Error: Failed to execute " + operation + ".");
            Console.WriteLine("=========================" + new string('=', operation.Length) + "=");
            //Console.WriteLine("==============================");
            Console.WriteLine("Reason: " + message + ".");
            Console.WriteLine("Error code: " + errorCode + ".");
            Console.WriteLine();
        }

        static void ReadAndProcessMessage()
        {
            string messageType = Console.ReadLine();
            if (messageType == "success")
            {
                string operation = Console.ReadLine();
                string message = Console.ReadLine();
                ShowSuccessMessage(operation, message);
            }
            if (messageType == "warning")
            {
                string message = Console.ReadLine();
                ShowWarningMessage(message);
            }
            if (messageType == "error")
            {
                string operation = Console.ReadLine();
                string message = Console.ReadLine();
                int errorCode = int.Parse(Console.ReadLine());
                ShowErrorMessage(operation, message, errorCode);
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n!= 0)
            {
                ReadAndProcessMessage();
                n--;
            }
        }
    }
}
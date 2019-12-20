using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main()
        {
            string passwd = Console.ReadLine();

            bool isLenghtOK = IsLenghtOK(passwd);
            bool hasOnlyLettersAndDigits = HasOnlyLettersAndDigits(passwd);
            bool hasTwoDigits = HasTwoDigits(passwd);

            if (isLenghtOK && hasOnlyLettersAndDigits && hasTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool IsLenghtOK(string passwd)
        {
            if (passwd.Length < 6 || passwd.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
            return true;
        }

        static bool HasOnlyLettersAndDigits(string passwd)
        {
            for (int i = 0; i < passwd.Length; i++)
            {
                if (passwd[i] < '0' || (passwd[i] > '9' && passwd[i] < 'A') || passwd[i] > 'z')
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    return false;
                }
            }

            return true;
        }

        static bool HasTwoDigits(string passwd)
        {
            int countDigits = 0;

            for (int i = 0; i < passwd.Length; i++)
            {
                if (passwd[i] >= '0' && passwd[i] <= '9')
                {
                    countDigits++;
                }
            }
            if (countDigits < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }

            return true;
        }

        
    }
}
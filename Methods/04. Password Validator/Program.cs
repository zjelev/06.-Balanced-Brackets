using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main()
        {
            string passwd = Console.ReadLine();

            bool isLenghtOK = true;
            bool isItOnlyLettersDigits = true;
            bool hasTwoDigits = false;

            if (passwd.Length < 6 || passwd.Length > 10 )
            {
                isLenghtOK = false;
            }

            int countDigits = 0;
            for (int i = 0; i < passwd.Length; i++)
            {
                if (passwd[i] < '0' || (passwd[i] > '9' && passwd[i] < 'A') 
                    || passwd[i] > 'z')
                {
                    isItOnlyLettersDigits = false;

                }
                else if (passwd[i] >= '0' && passwd[i] <= '9')
                {
                    countDigits++;
                }            
            }

            if (countDigits > 1)
            {
                hasTwoDigits = true;
            }

            if (!isLenghtOK)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!isItOnlyLettersDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!hasTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isLenghtOK && isItOnlyLettersDigits && hasTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }

        }
    }
}

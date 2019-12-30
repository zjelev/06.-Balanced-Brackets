using System;

namespace _5._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string user = Console.ReadLine();
            char[] reverse = user.ToCharArray();
            for (int i = reverse.Length - 1; i >= 0; i--)
            {
                reverse[reverse.Length - 1 - i] = user[i]; 
            }*/
            char[] user = Console.ReadLine().ToCharArray();
            string userString = new string(user);
            bool equal = false;
            for (int i = 0; i <= 3; i++)
            {
                equal = true;
                //string pass = Console.ReadLine();
                char[] passwd = Console.ReadLine().ToCharArray();
                if (passwd.Length != user.Length)
                {
                    equal = false;
                }
                else
                {
                    for (int j = 0; j < passwd.Length; j++)
                    {
                        if (user[user.Length - 1 - j] != passwd[j])
                        {
                            equal = false;
                            break;
                        }
                    }
                }
                if (equal)
                {
                    Console.WriteLine("User " + userString + " logged in.");
                    break;
                }
                else
                {
                    if (i <= 2)
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                    else
                    {
                        Console.WriteLine("User " + userString + " blocked!");
                    }
                }
            }
        }
    }
}
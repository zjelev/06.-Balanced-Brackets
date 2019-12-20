using System;

namespace _03.Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //top line
            Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('_', n + 4));
            //upper body
            int dots = n;
            int lines = n + 2;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', dots), new string('_', lines));
                dots--;
                lines = lines + 2;
            }
            //STOP line
            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', (lines - 4) / 2));
            //bottom
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', dots), new string('_', lines));
                dots++;
                lines = lines - 2;
            }
        }
    }
}

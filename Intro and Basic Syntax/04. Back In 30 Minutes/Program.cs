using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            //DateTime now = new DateTime(hours, minutes);
            //Console.WriteLine(string.Format("{0}:{1}", now.Hour, now.AddMinutes(30)));
            //Console.WriteLine(now.ToString("h:mm") + hours + minutes);
            minutes += 30;
            if (minutes > 59)
            {
                hours += 1;
                minutes -= 60;
            }
            if (hours > 23)
            {
                hours -= 24;
            }
            Console.WriteLine("{0}:{1:00}", hours, minutes);
        }
    }
}
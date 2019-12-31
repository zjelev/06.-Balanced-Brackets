using System;
using System.Globalization;
using System.Linq;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main()
        {
            //string date = Console.ReadLine();

            //int[] dateArr = date.Split("-").Select(int.Parse).ToArray();

            //DateTime day = new DateTime(dateArr[2], dateArr[1], dateArr[0]);

            //Console.WriteLine(day.DayOfWeek);
            //
            //var obj = new
            //{
            //    Name = "Ivan",
            //    Age = "50",
            //    Alcholol = "Da"
            //};
            //
            //Console.WriteLine(obj.Alcholol);

            //DateTime now = DateTime.Now;
            //
            //now = now.AddDays(8);
            //
            //string nowText = now.ToString("dddd, dd MMMM yyyy г.");
            //
            //Console.WriteLine(nowText);

            //DateTime date = DateTime.ParseExact(
            //    Console.ReadLine(),
            //    "yyyy-MM-dd",
            //    CultureInfo.InvariantCulture);
            //
            //Console.WriteLine(date.DayOfWeek);

            for (int i = 0; i < 100; i++)
            {
                Random random = new Random();

                Console.WriteLine(random.Next(2, 7));
            }

            //Console.WriteLine($"Even numbers: {sumEven}");
            //Console.WriteLine($"Odd numbers: {sumOdd}");
        }
    }
}

using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        //string[] formats = { "d.m.yyyy", "dd.m.yyyy", "d.m.yyyy", "dd.mm.yyyy" };
        var startDate = DateTime.Parse(Console.ReadLine(), CultureInfo.GetCultureInfo("bg-BG"));
        var endDate = DateTime.Parse(Console.ReadLine(), CultureInfo.GetCultureInfo("bg-BG"));
        int holidaysCount = 0;
        for (var date = startDate; date <= endDate; date = date.AddDays(1))
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                holidaysCount++;
            }
        }
        Console.WriteLine(holidaysCount);
    }
}
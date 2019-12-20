using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int projectHours = int.Parse(Console.ReadLine());

            int availableDays = int.Parse(Console.ReadLine());
            int overtimeWorkers = int.Parse(Console.ReadLine());

            double workDays = availableDays * 0.9;
            double workHours = workDays * 8;
            double overtimeHours = overtimeWorkers * availableDays * 2;

            double totalHours = Math.Floor(workHours + overtimeHours);
            
            if (totalHours >= projectHours)
            {
                Console.WriteLine("Yes!{0} hours left.", totalHours - projectHours);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", projectHours - totalHours);
            }
        }
    }
}

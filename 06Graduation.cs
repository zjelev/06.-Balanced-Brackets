using System;

namespace _06.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int year = 1;
            double totalGrade = 0;
            int excludedCounter = 0;
            while (year <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4)
                {
                    totalGrade += grade;
                    year++;
                }
                else
                {
                    excludedCounter++;
                }

                if (excludedCounter >= 2)
                {
                    Console.WriteLine($"{studentName} has been excluded at {year} grade");
                    break;
                }
            }
            if (year >= 12)
            {
                Console.WriteLine($"{studentName} graduated. Average grade: {totalGrade / 12:f2}");
            }
            
        }
    }
}

using System;

namespace _01.Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            int debitFirstPipe = int.Parse(Console.ReadLine());
            int debitSecondPipe = int.Parse(Console.ReadLine());
            double hoursAbsent = double.Parse(Console.ReadLine());

            double filledFirstPipe = debitFirstPipe * hoursAbsent;
            double filledSecondPipe = debitSecondPipe * hoursAbsent;

            double filled = filledFirstPipe + filledSecondPipe;

            if (volume < filled)
            {
                Console.WriteLine($"For {hoursAbsent:f2} hours the pool overflows with {filled - volume:f2} liters.");  
            }
            else
            {
                Console.WriteLine($"The pool is {filled / volume * 100:f2} % full. Pipe 1: " +
                    $"{filledFirstPipe / filled * 100:f2} %.Pipe 2: {filledSecondPipe / filled * 100:f2} %.");
            }
        }
    }
}

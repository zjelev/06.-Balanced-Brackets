using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            //double dul, sh, V = 0;
            Console.Write("Length: ");
            double lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            //V = (dul + sh + V) / 3;
            double vol = lenght * width * height / 3;
            Console.Write($"Pyramid Volume: {vol:f2}");
        }
    }
}

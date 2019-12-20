using System;

namespace _08.Fuel_Tank___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double litresFilled = double.Parse(Console.ReadLine());
            string hasCard = Console.ReadLine();

            double benzinPrice = 2.22;
            double diezelPrice = 2.33;
            double gasPrice = 0.93;

            double totalPrice = 0;

            if (hasCard == "Yes")
            {
                benzinPrice -= 0.18;
                diezelPrice -= 0.12;
                gasPrice -= 0.08;
            }

            if (fuelType == "Gasoline")
            {
                totalPrice = benzinPrice * litresFilled;
            }
            else if (fuelType == "Diesel")
            {
                totalPrice = diezelPrice * litresFilled;
            }
            else if (fuelType == "Gas")
            {
                totalPrice = gasPrice * litresFilled;
            }

            if (litresFilled > 25)
            {
                totalPrice *= 0.9;
            }
            else if (litresFilled >= 20)
            {
                totalPrice *= 0.92;
            }

            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}

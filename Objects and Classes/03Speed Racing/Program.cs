using System;
using System.Collections.Generic;

namespace _03Speed_Racing
{
    class SpeedRacing
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' '); ;
                Car car = new Car(input[0], int.Parse(input[1]), double.Parse(input[2]));
                cars.Add(car);
            }

            string drive;

            while ((drive = Console.ReadLine()) != "End")
            {
                string[] driveSplit = drive.Split(' ');

                string carModel = driveSplit[1];

                int distance = int.Parse(driveSplit[2]);

                cars.Find(x => x.Model == carModel).Drive(distance);
            }

            cars.ForEach(x => Console.WriteLine(x));
        }
    }

    class Car
    {
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumption { get; set; }

        public int DistanceTraveled { get; set; }

        public Car(string model, int fuelAmount, double fuelConsumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumption = fuelConsumption;
            this.DistanceTraveled = 0;
        }

        public void Drive(int distance)
        {
            if (distance * this.FuelConsumption <= this.FuelAmount)
            {
                this.FuelAmount -= distance * this.FuelConsumption;
                this.DistanceTraveled += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:f2} {this.DistanceTraveled}";
        }
    }
}
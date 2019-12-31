using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Vehicle_Catalogue
{
    class VehicleCatalog
    {
        static void Main()
        {
            string input;

            List<Vehicle> vehicles = new List<Vehicle>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] token = input.Split(" ");

                Vehicle vehicle = new Vehicle(token[0].ToLower(), token[1], token[2], int.Parse(token[3]));

                vehicles.Add(vehicle);
            }

            string model;

            while ((model = Console.ReadLine()) != "Close the Catalogue")
            {
                Console.WriteLine(vehicles.Find(x => x.Model == model));
            }

            List<Vehicle> cars = vehicles.Where(x => x.Type == "car").ToList();

            if (cars.Count > 0)
            {
                int sumCarsHP = 0;

                cars.ForEach(x => sumCarsHP += x.HPower);

                Console.WriteLine($"Cars have average horsepower of: {(double)sumCarsHP / cars.Count:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            List<Vehicle> trucks = vehicles.Where(x => x.Type == "truck").ToList();

            if (trucks.Count > 0)
            {
                int sumTrucksHP = 0;

                trucks.ForEach(x => sumTrucksHP += x.HPower);

                Console.WriteLine($"Trucks have average horsepower of: {(double)sumTrucksHP / trucks.Count:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }
        }
    }

    class Vehicle
    {
        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int HPower { get; set; }

        public Vehicle(string type, string model, string color, int hp)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HPower = hp;
        }

        public override string ToString()
        {
            return $"Type: {(this.Type == "car" ? "Car" : "Truck")}{Environment.NewLine}" +
                                $"Model: {this.Model}{Environment.NewLine}" +
                                $"Color: {this.Color}{Environment.NewLine}" +
                                $"Horsepower: {this.HPower}";
        }
    }
}
using System;
using System.Collections.Generic;

namespace RawData
{
    class SpeedRacing
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputStr = input.Split(' ');
                string model = inputStr[0];
                int engineSpeed = int.Parse(inputStr[1]);
                int enginePower = int.Parse(inputStr[2]);
                int cargoWeight = int.Parse(inputStr[3]);
                string cargoType = inputStr[4];

                Car car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            foreach (var car in cars)
            {
                if (car.Cargo.Type == command)
                {
                    if (command == "fragile" && car.Cargo.Weight < 1000)
                    {
                        Console.WriteLine(car.Model);
                    }
                    else if (command == "flamable" && car.Engine.Power > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }           
        }
    }

    class Car 
    {
        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public Car(string model, int speed, int power, int weight, string cargoType)
        {
            this.Model = model;
            this.Engine = new Engine(speed, power);
            this.Cargo = new Cargo(weight, cargoType);
        }
    }

    class Engine
    {
        public int Speed {get; set;}

        public int Power {get; set;}

        public Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }
    }

    class Cargo
    {
        public int Weight {get; set;}

        public string Type {get; set;}

        public Cargo (int weight, string type)
        {
            this.Weight = weight;
            this.Type = type;
        }
    }
}
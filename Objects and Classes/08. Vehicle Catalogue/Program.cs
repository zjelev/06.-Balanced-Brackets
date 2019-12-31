//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace _08._Vehicle_Catalogue
//{
//    class VehicleCatalog
//    {
//        public VehicleCatalog()
//        {
//            Cars = new List<Car>();
//            Trucks = new List<Truck>();
//        }

//        public List<Car> Cars { get; set; }

//        public List<Truck> Trucks { get; set; }

//        static void Main()
//        {
//            string input;

//            VehicleCatalog catalog = new VehicleCatalog();
//            List<Car> cars = catalog.Cars;
//            List<Truck> trucks = catalog.Trucks;

//            while ((input = Console.ReadLine()) != "end")
//            {
//                string[] token = input.Split('/');

//                string type = token[0];

//                string brand = token[1];

//                string model = token[2];

//                int horsePowerOrWeight = int.Parse(token[3]);

//                if (type == "Car")
//                {
//                    Car car = new Car();
                    
//                    car.Brand = brand;
//                    car.Model = model;
//                    car.HorsePower = horsePowerOrWeight;

//                    cars.Add(car);
//                }
//                else
//                {
//                    Truck truck = new Truck();
                    
//                    truck.Brand = brand;
//                    truck.Model = model;
//                    truck.Weight = horsePowerOrWeight;

//                    trucks.Add(truck);
//                }

//            }

//            if (cars.Count > 0)
//            {
//                Console.WriteLine("Cars:");

//                cars = cars.OrderBy(a => a.Brand).ToList();

//                foreach (var car in cars)
//                {
//                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
//                }
//            }
//            if (trucks.Count > 0)
//            {
//                Console.WriteLine("Trucks:");

//                trucks = trucks.OrderBy(a => a.Brand).ToList();

//                foreach (var truck in trucks)
//                {
//                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
//                }
//            }
//        }
//    }

//    class Truck
//    {
//        public string Brand { get; set; }

//        public string Model { get; set; }

//        public int Weight { get; set; }
//    }

//    class Car
//    {
//        public string Brand { get; set; }

//        public string Model { get; set; }

//        public int HorsePower { get; set; }
//    }
//}
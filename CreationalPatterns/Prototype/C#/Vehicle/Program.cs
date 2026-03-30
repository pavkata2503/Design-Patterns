using System;
using System.Collections.Generic;

namespace PrototypeVehicleDemo
{

    class Program
    {
        static void Main(string[] args)
        {
            VehicleManager manager = new VehicleManager();

            manager["sportCar"] = new Vehicle("BMW", "M4", "Car", 250, "Petrol");
            manager["truck"] = new Vehicle("Volvo", "FH16", "Truck", 180, "Diesel");
            manager["electricCar"] = new Vehicle("Tesla", "Model S", "Car", 260, "Electric");

            Vehicle sportCarClone = manager["sportCar"].Clone() as Vehicle;
            Vehicle truckClone = manager["truck"].Clone() as Vehicle;
            Vehicle electricCarClone = manager["electricCar"].Clone() as Vehicle;

            sportCarClone.Model = "M4 Competition";
            sportCarClone.MaxSpeed = 290;

            truckClone.Model = "FH16 Heavy Duty";
            truckClone.MaxSpeed = 170;

            electricCarClone.Model = "Model S Plaid";
            electricCarClone.MaxSpeed = 322;

            Console.WriteLine("Original prototypes:");
            Console.WriteLine(manager["sportCar"]);
            Console.WriteLine(manager["truck"]);
            Console.WriteLine(manager["electricCar"]);

            Console.WriteLine();
            Console.WriteLine("Cloned and modified vehicles:");
            Console.WriteLine(sportCarClone);
            Console.WriteLine(truckClone);
            Console.WriteLine(electricCarClone);
        }
    }
}
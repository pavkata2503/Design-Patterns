using System;
using Vehicles.ConcreteFactories;
using Vehicles.Interfaces;

namespace Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select vehicle origin:");
            Console.WriteLine("[1] German, [2] Japanese, [3] Italian");

            if (int.TryParse(Console.ReadLine(), out int vehicleOrigin))
            {
                IVehicleFactory vehicleFactory = null;

                switch (vehicleOrigin)
                {
                    case 1:
                        vehicleFactory = new GermanVehicleFactory();
                        break;
                    case 2:
                        vehicleFactory = new JapaneseVehicleFactory();
                        break;
                    case 3:
                        vehicleFactory = new ItalianVehicleFactory();
                        break;
                }

                if (vehicleFactory == null)
                {
                    Console.WriteLine("Invalid vehicle origin.");
                    return;
                }

                Console.WriteLine("Please select vehicle type:");
                Console.WriteLine("[1] Sedan, [2] SUV, [3] Sports Car");

                if (int.TryParse(Console.ReadLine(), out int vehicleType))
                {
                    IVehicle vehicle = null;

                    switch (vehicleType)
                    {
                        case 1:
                            vehicle = vehicleFactory.CreateSedan();
                            break;
                        case 2:
                            vehicle = vehicleFactory.CreateSUV();
                            break;
                        case 3:
                            vehicle = vehicleFactory.CreateSportsCar();
                            break;
                    }

                    if (vehicle == null)
                    {
                        Console.WriteLine("Invalid vehicle type.");
                        return;
                    }

                    vehicle.ShowVehicleInfo();
                }
            }
        }
    }
}
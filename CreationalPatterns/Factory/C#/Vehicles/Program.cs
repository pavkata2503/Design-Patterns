using System;
using System.Collections.Generic;
using Vehicles.Creators;
using Vehicles.Extensions;
using Vehicles.Products;

namespace Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IVehicleCreator[] vehicleCreators = new IVehicleCreator[]
                {
                    new CarCreator(),
                    new MotorcycleCreator(),
                    new TruckCreator()
                };

                List<Vehicle> vehicles = new List<Vehicle>();

                foreach (var vehicleCreator in vehicleCreators)
                {
                    var vehicleTypeFromCreator = vehicleCreator.GetType().Name
                        .Replace("Creator", string.Empty)
                        .SplitPascalCaseString();

                    Console.WriteLine($"Enter vehicle details for type {vehicleTypeFromCreator}: ");

                    Console.Write("Enter model: ");
                    string vehicleModel = Console.ReadLine();

                    Console.Write("Enter max speed: ");
                    int vehicleMaxSpeed = int.Parse(Console.ReadLine());

                    Console.Write("Enter price: ");
                    decimal vehiclePrice = decimal.Parse(Console.ReadLine());

                    Vehicle createdVehicle = vehicleCreator.CreateVehicle(
                        vehicleModel, vehicleMaxSpeed, vehiclePrice
                    );

                    vehicles.Add(createdVehicle);
                }

                foreach (var vehicle in vehicles)
                {
                    Console.WriteLine(vehicle.ToString());
                }
            }
            catch (Exception exception)
            {
                if (exception is FormatException)
                {
                    Console.WriteLine("Aborting! Found entry with wrong format!");
                }
                else
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }
    }
}
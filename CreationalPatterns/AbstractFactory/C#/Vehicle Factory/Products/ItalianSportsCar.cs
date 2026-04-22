using System;
using Vehicles.Interfaces;

namespace Vehicles.Products
{
    public class ItalianSportsCar : IVehicle
    {
        public void ShowVehicleInfo()
        {
            Console.WriteLine("I am an Italian sports car");
        }
    }
}
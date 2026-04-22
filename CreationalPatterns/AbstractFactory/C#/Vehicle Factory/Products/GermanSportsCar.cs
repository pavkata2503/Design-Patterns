using System;
using Vehicles.Interfaces;

namespace Vehicles.Products
{
    public class GermanSportsCar : IVehicle
    {
        public void ShowVehicleInfo()
        {
            Console.WriteLine("I am a German sports car");
        }
    }
}
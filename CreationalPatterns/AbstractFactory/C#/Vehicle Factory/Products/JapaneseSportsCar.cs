using System;
using Vehicles.Interfaces;

namespace Vehicles.Products
{
    public class JapaneseSportsCar : IVehicle
    {
        public void ShowVehicleInfo()
        {
            Console.WriteLine("I am a Japanese sports car");
        }
    }
}
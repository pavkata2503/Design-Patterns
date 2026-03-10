using System;
using Vehicles.Interfaces;

namespace Vehicles.Products
{
    public class GermanSUV : IVehicle
    {
        public void ShowVehicleInfo()
        {
            Console.WriteLine("I am a German SUV");
        }
    }
}
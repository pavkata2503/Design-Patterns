using System;
using Vehicles.Interfaces;

namespace Vehicles.Products
{
    public class ItalianSUV : IVehicle
    {
        public void ShowVehicleInfo()
        {
            Console.WriteLine("I am an Italian SUV");
        }
    }
}
using System;
using Vehicles.Interfaces;

namespace Vehicles.Products
{
    public class ItalianSedan : IVehicle
    {
        public void ShowVehicleInfo()
        {
            Console.WriteLine("I am an Italian sedan");
        }
    }
}
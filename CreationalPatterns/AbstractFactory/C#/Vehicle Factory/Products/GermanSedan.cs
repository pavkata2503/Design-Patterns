using System;
using Vehicles.Interfaces;

namespace Vehicles.Products
{
    public class GermanSedan : IVehicle
    {
        public void ShowVehicleInfo()
        {
            Console.WriteLine("I am a German sedan");
        }
    }
}
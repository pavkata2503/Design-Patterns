using System;
using Vehicles.Interfaces;

namespace Vehicles.Products
{
    public class JapaneseSedan : IVehicle
    {
        public void ShowVehicleInfo()
        {
            Console.WriteLine("I am a Japanese sedan");
        }
    }
}
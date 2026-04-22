using System;
using Vehicles.Interfaces;

namespace Vehicles.Products
{
    public class JapaneseSUV : IVehicle
    {
        public void ShowVehicleInfo()
        {
            Console.WriteLine("I am a Japanese SUV");
        }
    }
}
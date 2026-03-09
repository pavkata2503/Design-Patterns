using System.Diagnostics;
using Vehicles.Products;

namespace Vehicles.Creators
{
    public class TruckCreator : IVehicleCreator
    {
        public Vehicle CreateVehicle(string model, int maxSpeed, decimal price)
            => new Truck(model, maxSpeed, price);
    }
}
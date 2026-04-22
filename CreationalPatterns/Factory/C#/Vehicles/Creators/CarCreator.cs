using System.Runtime.ConstrainedExecution;
using Vehicles.Products;

namespace Vehicles.Creators
{
    public class CarCreator : IVehicleCreator
    {
        public Vehicle CreateVehicle(string model, int maxSpeed, decimal price)
            => new Car(model, maxSpeed, price);
    }
}
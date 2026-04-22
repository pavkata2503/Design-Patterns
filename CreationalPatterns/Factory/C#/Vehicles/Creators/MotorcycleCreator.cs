using Vehicles.Products;

namespace Vehicles.Creators
{
    public class MotorcycleCreator : IVehicleCreator
    {
        public Vehicle CreateVehicle(string model, int maxSpeed, decimal price)
            => new Motorcycle(model, maxSpeed, price);
    }
}
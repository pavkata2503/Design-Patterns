using Vehicles.Products;

namespace Vehicles.Creators
{
    public interface IVehicleCreator
    {
        Vehicle CreateVehicle(string model, int maxSpeed, decimal price);
    }
}
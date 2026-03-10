using Vehicles.Interfaces;
using Vehicles.Products;

namespace Vehicles.ConcreteFactories
{
    public class GermanVehicleFactory : IVehicleFactory
    {
        public IVehicle CreateSedan()
        {
            return new GermanSedan();
        }

        public IVehicle CreateSUV()
        {
            return new GermanSUV();
        }

        public IVehicle CreateSportsCar()
        {
            return new GermanSportsCar();
        }
    }
}
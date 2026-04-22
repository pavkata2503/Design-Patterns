using Vehicles.Interfaces;
using Vehicles.Products;

namespace Vehicles.ConcreteFactories
{
    public class ItalianVehicleFactory : IVehicleFactory
    {
        public IVehicle CreateSedan()
        {
            return new ItalianSedan();
        }

        public IVehicle CreateSUV()
        {
            return new ItalianSUV();
        }

        public IVehicle CreateSportsCar()
        {
            return new ItalianSportsCar();
        }
    }
}
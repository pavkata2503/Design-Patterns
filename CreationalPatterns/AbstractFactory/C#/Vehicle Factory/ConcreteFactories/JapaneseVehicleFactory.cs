using Vehicles.Interfaces;
using Vehicles.Products;

namespace Vehicles.ConcreteFactories
{
    public class JapaneseVehicleFactory : IVehicleFactory
    {
        public IVehicle CreateSedan()
        {
            return new JapaneseSedan();
        }

        public IVehicle CreateSUV()
        {
            return new JapaneseSUV();
        }

        public IVehicle CreateSportsCar()
        {
            return new JapaneseSportsCar();
        }
    }
}
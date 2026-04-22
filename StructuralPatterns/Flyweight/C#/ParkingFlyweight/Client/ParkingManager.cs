using ParkingFlyweight.Factories;
using ParkingFlyweight.Models;

namespace ParkingFlyweight.Client
{
    public class ParkingManager
    {
        private readonly CarFlyweightFactory factory;

        public ParkingManager(CarFlyweightFactory factory)
        {
            this.factory = factory;
        }

        public void ParkCar(Car car, ParkingInfo info)
        {
            var flyweight = factory.GetFlyweight(car);
            flyweight.Display(info);
        }
    }
}
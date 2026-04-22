using ParkingFlyweight.Flyweights;
using ParkingFlyweight.Models;

namespace ParkingFlyweight.Factories
{
    public class CarFlyweightFactory
    {
        private Dictionary<string, CarFlyweight> flyweights = new();

        private string GetKey(Car car)
            => $"{car.Brand}_{car.Model}_{car.Color}";

        public CarFlyweight GetFlyweight(Car car)
        {
            var key = GetKey(car);

            if (!flyweights.ContainsKey(key))
            {
                Console.WriteLine("Creating new flyweight...");
                flyweights[key] = new CarFlyweight(car);
            }
            else
            {
                Console.WriteLine("Reusing existing flyweight...");
            }

            return flyweights[key];
        }

        public void ListFlyweights()
        {
            Console.WriteLine($"Flyweights count: {flyweights.Count}");
        }
    }
}
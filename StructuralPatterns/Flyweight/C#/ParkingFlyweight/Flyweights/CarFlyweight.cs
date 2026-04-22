using ParkingFlyweight.Models;

namespace ParkingFlyweight.Flyweights
{
    public class CarFlyweight
    {
        private readonly Car sharedState;

        public CarFlyweight(Car car)
        {
            sharedState = car;
        }

        public void Display(ParkingInfo uniqueState)
        {
            Console.WriteLine(
                $"Shared -> {sharedState.Brand} {sharedState.Model} {sharedState.Color}" +
                $" | Unique -> {uniqueState.Owner} {uniqueState.LicenseNumber}" +
                $" Spot:{uniqueState.ParkingSpot}");
        }
    }
}
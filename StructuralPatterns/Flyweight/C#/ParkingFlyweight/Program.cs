using ParkingFlyweight.Client;
using ParkingFlyweight.Factories;
using ParkingFlyweight.Models;

class Program
{
    static void Main()
    {
        var factory = new CarFlyweightFactory();
        var parking = new ParkingManager(factory);

        parking.ParkCar(
            new Car { Brand = "BMW", Model = "M5", Color = "Red" },
            new ParkingInfo { Owner = "Ivan", LicenseNumber = "BT1234", ParkingSpot = 1 });

        parking.ParkCar(
            new Car { Brand = "BMW", Model = "M5", Color = "Red" },
            new ParkingInfo { Owner = "Maria", LicenseNumber = "BT9999", ParkingSpot = 2 });

        factory.ListFlyweights();
    }
}
using CarFacade.Facades;

namespace CarFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Facades.CarFacade();

            car.StartTrip("Sofia");
        }
    }
}
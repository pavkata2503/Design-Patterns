using CarAdapterExample.Adapter;
using CarAdapterExample.Target;

namespace CarAdapterExample
{
    class Program
    {
        static void Main()
        {
            ICarSpeed car = new CarSpeedAdapter();

            Console.WriteLine($"Speed in km/h: {car.GetSpeedInKmH()}");
        }
    }
}
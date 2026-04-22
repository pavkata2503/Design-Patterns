using CarAdapterExample.Adaptee;
using CarAdapterExample.Target;

namespace CarAdapterExample.Adapter
{
    public class CarSpeedAdapter : ICarSpeed
    {
        private readonly OldCarSpeedSystem oldSystem;

        public CarSpeedAdapter()
        {
            oldSystem = new OldCarSpeedSystem();
        }

        public double GetSpeedInKmH()
        {
            double mph = oldSystem.GetSpeedInMiles();
            return ConvertToKmH(mph);
        }

        private double ConvertToKmH(double mph)
        {
            return mph * 1.60934;
        }
    }
}
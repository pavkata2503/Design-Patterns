using CarBuilderExample.Builders;

namespace CarBuilderExample.Director
{
    public class CarFactory
    {
        public void Construct(CarBuilder builder)
        {
            builder.BuildEngine();
            builder.BuildTransmission();
            builder.BuildInterior();
            builder.BuildInfotainment();
        }
    }
}
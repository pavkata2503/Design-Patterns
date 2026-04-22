using CarBuilderExample.Models;

namespace CarBuilderExample.Builders
{
    public abstract class CarBuilder
    {
        public Car Car { get; protected set; }

        public abstract void BuildEngine();
        public abstract void BuildTransmission();
        public abstract void BuildInterior();
        public abstract void BuildInfotainment();
    }
}
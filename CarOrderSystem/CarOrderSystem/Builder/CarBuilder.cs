using CarOrderSystem.Composite;
using CarOrderSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarOrderSystem.Builder
{
    public abstract class CarBuilder: IBuilder
    {
        protected CarComposite car = new CarComposite("Car");

        public abstract IBuilder AddEngine();
        public abstract IBuilder AddWheels();
        public abstract IBuilder AddLuxuryPackage();

        public CarComposite Build()
        {
            return car;
        }
    }
}

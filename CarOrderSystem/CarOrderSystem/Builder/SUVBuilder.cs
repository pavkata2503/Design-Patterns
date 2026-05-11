using CarOrderSystem.Composite;
using CarOrderSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace CarOrderSystem.Builder
{
    internal class SUVBuilder:CarBuilder
    {
        public override IBuilder AddEngine()
        {
            car.Add(new Part("SUV Engine", 6000));
            return this;
        }

        public override IBuilder AddWheels()
        {
            car.Add(new Part("Off-road Wheels", 1500));
            return this;
        }

        public override IBuilder AddLuxuryPackage()
        {
            var luxury = new CarComposite("SUV Luxury");
            luxury.Add(new Part("Panoramic roof", 2000));

            car.Add(luxury);
            return this;
        }
    }
}

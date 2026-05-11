using CarOrderSystem.Composite;
using CarOrderSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace CarOrderSystem.Builder
{
    internal class SedanBuilder:CarBuilder
    {
        public override IBuilder AddEngine()
        {
            car.Add(new Part("Sedan Engine", 4000));
            return this;
        }

        public override IBuilder AddWheels()
        {
            car.Add(new Part("Standard Wheels", 1000));
            return this;
        }

        public override IBuilder AddLuxuryPackage()
        {
            var luxury = new CarComposite("Sedan Luxury");
            luxury.Add(new Part("Heated seats", 1200));

            car.Add(luxury);
            return this;
        }
    }
}

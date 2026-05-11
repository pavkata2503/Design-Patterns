using CarOrderSystem.Composite;
using CarOrderSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace CarOrderSystem.Builder
{
    internal class SportBuilder:CarBuilder
    {
        public override IBuilder AddEngine()
        {
            car.Add(new Part("Sport Engine", 8000));
            return this;
        }

        public override IBuilder AddWheels()
        {
            car.Add(new Part("Sport Wheels", 2000));
            return this;
        }

        public override IBuilder AddLuxuryPackage()
        {
            var luxury = new CarComposite("Sport Package");
            luxury.Add(new Part("Carbon interior", 3000));

            car.Add(luxury);
            return this;
        }
    }
}

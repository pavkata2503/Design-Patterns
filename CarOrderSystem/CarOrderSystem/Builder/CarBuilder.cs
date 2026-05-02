using CarOrderSystem.Composite;
using CarOrderSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarOrderSystem.Builder
{
    public class CarBuilder: IBuilder
    {
        private CarComposite car = new CarComposite("Car");

        public IBuilder AddEngine()
        {
            car.Add(new Part("Engine", 5000));
            return this;
        }

        public IBuilder AddWheels()
        {
            car.Add(new Part("Wheels", 1200));
            return this;
        }

        public IBuilder AddLuxuryPackage()
        {
            var luxury = new CarComposite("Luxury Package");
            luxury.Add(new Part("Leather seats", 3000));
            luxury.Add(new Part("Premium sound", 2500));

            car.Add(luxury);
            return this;
        }

        public CarComposite Build()
        {
            return car;
        }
    }
}

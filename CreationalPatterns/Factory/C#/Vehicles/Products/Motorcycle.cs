using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Products
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string model, int maxSpeed, decimal price)
            : base(model, maxSpeed, price)
        {
        }
    }
}

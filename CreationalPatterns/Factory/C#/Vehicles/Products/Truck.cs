using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Products
{
    public class Truck : Vehicle
    {
        public Truck(string model, int maxSpeed, decimal price)
            : base(model, maxSpeed, price)
        {
        }
    }
}
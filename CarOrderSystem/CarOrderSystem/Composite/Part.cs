using System;
using System.Collections.Generic;
using System.Text;

namespace CarOrderSystem.Composite
{
    public class Part : CarComponent
    {
        private double price;

        public Part(string name, double price)
        {
            Name = name;
            this.price = price;
        }

        public override double GetPrice()
        {
            return price;
        }
    }
}

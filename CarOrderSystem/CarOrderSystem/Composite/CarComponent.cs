using System;
using System.Collections.Generic;
using System.Text;

namespace CarOrderSystem.Composite
{
    public abstract class CarComponent
    {
        public string Name { get; set; }
        public abstract double GetPrice();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CarOrderSystem.Composite
{
    public class CarComposite : CarComponent
    {
        private List<CarComponent> components = new List<CarComponent>();

        public CarComposite(string name)
        {
            Name = name;
        }

        public void Add(CarComponent component)
        {
            components.Add(component);
        }

        public override double GetPrice()
        {
            double total = 0;
            foreach (var c in components)
            {
                total += c.GetPrice();
            }
            return total;
        }
    }
}

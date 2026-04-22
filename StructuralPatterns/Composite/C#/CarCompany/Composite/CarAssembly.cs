using System;
using System.Collections.Generic;
using CarCompany.Core;

namespace CarCompany.Composite
{
    public class CarAssembly : CarComponent
    {
        private List<CarComponent> components =
            new List<CarComponent>();

        public CarAssembly(string name, double price)
            : base(name, price)
        {
        }

        public override void Add(CarComponent component)
        {
            components.Add(component);
        }

        public override void Remove(CarComponent component)
        {
            components.Remove(component);
        }

        public override void Display(int level)
        {
            Console.WriteLine($"{new string('-', level)}+ {Name} (${Price})");

            foreach (var component in components)
            {
                component.Display(level + 2);
            }
        }
    }
}
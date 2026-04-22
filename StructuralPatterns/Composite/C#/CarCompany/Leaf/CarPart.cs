using System;
using CarCompany.Core;

namespace CarCompany.Leaf
{
    public class CarPart : CarComponent
    {
        public CarPart(string name, double price)
            : base(name, price)
        {
        }

        public override void Add(CarComponent component)
        {
            Console.WriteLine("Cannot add to single part");
        }

        public override void Remove(CarComponent component)
        {
            Console.WriteLine("Cannot remove from single part");
        }

        public override void Display(int level)
        {
            Console.WriteLine($"{new string('-', level)} {Name} (${Price})");
        }
    }
}
using System;

namespace CarCompany.Core
{
    public abstract class CarComponent
    {
        protected string Name;
        protected double Price;

        protected CarComponent(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public abstract void Add(CarComponent component);
        public abstract void Remove(CarComponent component);
        public abstract void Display(int level);
    }
}
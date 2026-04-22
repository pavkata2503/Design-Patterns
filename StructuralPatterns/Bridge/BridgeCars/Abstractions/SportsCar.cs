using System;
using BridgeCars.Implementors;

namespace BridgeCars.Abstractions
{
    public class SportsCar : Car
    {
        public SportsCar(Engine engine) : base(engine) { }

        public override void Drive()
        {
            Console.WriteLine("Sports car driving...");
            Engine.Start();
        }
    }
}
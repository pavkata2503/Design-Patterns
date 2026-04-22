using System;
using BridgeCars.Implementors;

namespace BridgeCars.Abstractions
{
    public class FamilyCar : Car
    {
        public FamilyCar(Engine engine) : base(engine) { }

        public override void Drive()
        {
            Console.WriteLine("Family car driving...");
            Engine.Start();
        }
    }
}
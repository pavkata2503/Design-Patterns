using System;

namespace BridgeCars.Implementors
{
    public class ElectricEngine : Engine
    {
        public override void Start()
            => Console.WriteLine("Electric engine started");

        public override void Stop()
            => Console.WriteLine("Electric engine stopped");
    }
}
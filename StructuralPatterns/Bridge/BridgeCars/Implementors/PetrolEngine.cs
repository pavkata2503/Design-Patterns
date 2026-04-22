using System;

namespace BridgeCars.Implementors
{
    public class PetrolEngine : Engine
    {
        public override void Start()
            => Console.WriteLine("Petrol engine started");

        public override void Stop()
            => Console.WriteLine("Petrol engine stopped");
    }
}
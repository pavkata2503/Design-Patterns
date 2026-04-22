using BridgeCars.Implementors;

namespace BridgeCars.Abstractions
{
    public abstract class Car
    {
        protected Engine Engine;

        protected Car(Engine engine)
        {
            Engine = engine;
        }

        public abstract void Drive();
    }
}
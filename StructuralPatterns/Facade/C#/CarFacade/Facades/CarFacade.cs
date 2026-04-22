using CarFacade.Subsystems;

namespace CarFacade.Facades
{
    public class CarFacade
    {
        private Engine engine;
        private FuelSystem fuel;
        private NavigationSystem navigation;
        private AirConditioning ac;

        public CarFacade()
        {
            engine = new Engine();
            fuel = new FuelSystem();
            navigation = new NavigationSystem();
            ac = new AirConditioning();
        }

        public void StartTrip(string destination)
        {
            fuel.CheckFuel();
            engine.Start();
            navigation.SetDestination(destination);
            ac.TurnOn();
        }
    }
}
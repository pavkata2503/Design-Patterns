using System;

namespace CarFacade.Subsystems
{
    public class NavigationSystem
    {
        public void SetDestination(string destination)
        {
            Console.WriteLine($"Navigation set to {destination}");
        }
    }
}
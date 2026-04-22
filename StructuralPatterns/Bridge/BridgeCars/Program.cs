using BridgeCars.Abstractions;
using BridgeCars.Implementors;

namespace BridgeCars
{
    class Program
    {
        static void Main()
        {
            Car car1 = new SportsCar(new PetrolEngine());
            car1.Drive();

            Car car2 = new FamilyCar(new ElectricEngine());
            car2.Drive();
        }
    }
}
using CarCompany.Composite;
using CarCompany.Leaf;

namespace CarCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new CarAssembly("BMW M5", 50000);

            var engineSystem = new CarAssembly("Engine System", 15000);
            engineSystem.Add(new CarPart("Engine", 10000));
            engineSystem.Add(new CarPart("Radiator", 2000));

            var wheelSystem = new CarAssembly("Wheel System", 5000);
            wheelSystem.Add(new CarPart("Front Left Wheel", 1000));
            wheelSystem.Add(new CarPart("Front Right Wheel", 1000));
            wheelSystem.Add(new CarPart("Rear Left Wheel", 1000));
            wheelSystem.Add(new CarPart("Rear Right Wheel", 1000));

            car.Add(engineSystem);
            car.Add(wheelSystem);
            car.Add(new CarPart("Steering Wheel", 800));

            car.Display(1);
        }
    }
}
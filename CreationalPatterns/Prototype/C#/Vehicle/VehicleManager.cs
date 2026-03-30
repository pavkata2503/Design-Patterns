namespace PrototypeVehicleDemo
{
    public class VehicleManager
    {
        private Dictionary<string, VehiclePrototype> vehicles = new Dictionary<string, VehiclePrototype>();

        public VehiclePrototype this[string key]
        {
            get => vehicles[key];
            set => vehicles[key] = value;
        }
    }
}
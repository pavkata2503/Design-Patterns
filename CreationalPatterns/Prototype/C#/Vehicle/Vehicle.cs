namespace PrototypeVehicleDemo
{
    public class Vehicle : VehiclePrototype
    {
        public Vehicle(string brand, string model, string type, int maxSpeed, string fuelType)
        {
            Brand = brand;
            Model = model;
            Type = type;
            MaxSpeed = maxSpeed;
            FuelType = fuelType;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }       
        public int MaxSpeed { get; set; }
        public string FuelType { get; set; }  

        public override VehiclePrototype Clone()
        {
            // shallow copy
            return MemberwiseClone() as VehiclePrototype;
        }

        public override string ToString()
        {
            return $"Vehicle: {Brand} {Model}, Type: {Type}, MaxSpeed: {MaxSpeed} km/h, Fuel: {FuelType}";
        }
    }
}
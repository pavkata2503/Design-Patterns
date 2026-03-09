using System;
using Vehicles.Extensions;

namespace Vehicles.Products
{
    public abstract class Vehicle
    {
        private const int VehicleMinimumSpeed = 20;
        private const int VehicleMaximumSpeed = 400;

        private const decimal VehicleMinimumPrice = 1000;
        private const decimal VehicleMaximumPrice = 1000000;

        private const string NullOrWhiteSpaceVehicleModelErrorMessage = "The {0}'s model cannot be empty!";
        private const string VehicleSpeedOutOfRangeErrorMessage = "The vehicle's speed must be between {0} and {1}!";
        private const string VehiclePriceOutOfRangeErrorMessage = "The vehicle's price must be between {0} and {1}!";

        private string model;
        private int maxSpeed;
        private decimal price;

        protected Vehicle(string model, int maxSpeed, decimal price)
        {
            Model = model;
            MaxSpeed = maxSpeed;
            Price = price;
        }

        public string Model
        {
            get => model;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        string.Format(NullOrWhiteSpaceVehicleModelErrorMessage, GetType().Name.SplitPascalCaseString())
                    );
                }

                model = value;
            }
        }

        public int MaxSpeed
        {
            get => maxSpeed;
            set
            {
                if (value < VehicleMinimumSpeed || value > VehicleMaximumSpeed)
                {
                    throw new ArgumentException(
                        string.Format(VehicleSpeedOutOfRangeErrorMessage, VehicleMinimumSpeed, VehicleMaximumSpeed)
                    );
                }

                maxSpeed = value;
            }
        }

        public decimal Price
        {
            get => price;
            set
            {
                if (value < VehicleMinimumPrice || value > VehicleMaximumPrice)
                {
                    throw new ArgumentException(
                        string.Format(VehiclePriceOutOfRangeErrorMessage, VehicleMinimumPrice, VehicleMaximumPrice)
                    );
                }

                price = value;
            }
        }

        public override string ToString()
        {
            return $"Vehicle: {GetType().Name.SplitPascalCaseString()} with model: {Model}, max speed: {MaxSpeed} and price: {Price}";
        }
    }
}
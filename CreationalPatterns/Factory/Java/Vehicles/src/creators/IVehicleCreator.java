package creators;

import products.Vehicle;

public interface IVehicleCreator {
    Vehicle createVehicle(String model, int maxSpeed, double price);
}
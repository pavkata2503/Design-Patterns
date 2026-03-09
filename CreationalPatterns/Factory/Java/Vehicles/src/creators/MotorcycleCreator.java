package creators;

import products.Motorcycle;
import products.Vehicle;

public class MotorcycleCreator implements IVehicleCreator {
    @Override
    public Vehicle createVehicle(String model, int maxSpeed, double price) {
        return new Motorcycle(model, maxSpeed, price);
    }
}
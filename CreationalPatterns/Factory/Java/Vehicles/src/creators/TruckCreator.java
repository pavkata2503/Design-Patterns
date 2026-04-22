package creators;

import products.Truck;
import products.Vehicle;

public class TruckCreator implements IVehicleCreator {
    @Override
    public Vehicle createVehicle(String model, int maxSpeed, double price) {
        return new Truck(model, maxSpeed, price);
    }
}
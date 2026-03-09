package creators;

import products.Car;
import products.Vehicle;

public class CarCreator implements IVehicleCreator {
    @Override
    public Vehicle createVehicle(String model, int maxSpeed, double price) {
        return new Car(model, maxSpeed, price);
    }
}
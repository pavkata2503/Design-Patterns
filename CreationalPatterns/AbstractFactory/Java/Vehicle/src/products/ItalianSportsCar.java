package products;

import interfaces.IVehicle;

public class ItalianSportsCar implements IVehicle {

    @Override
    public void showVehicleInfo() {
        System.out.println("I am an Italian sports car");
    }
}
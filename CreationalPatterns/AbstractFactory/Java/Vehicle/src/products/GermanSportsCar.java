package products;

import interfaces.IVehicle;

public class GermanSportsCar implements IVehicle {

    @Override
    public void showVehicleInfo() {
        System.out.println("I am a German sports car");
    }
}
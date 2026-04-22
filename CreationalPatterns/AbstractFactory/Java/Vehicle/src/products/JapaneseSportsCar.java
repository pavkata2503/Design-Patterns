package products;

import interfaces.IVehicle;

public class JapaneseSportsCar implements IVehicle {

    @Override
    public void showVehicleInfo() {
        System.out.println("I am a Japanese sports car");
    }
}
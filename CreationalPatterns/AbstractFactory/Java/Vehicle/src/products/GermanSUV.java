package products;

import interfaces.IVehicle;

public class GermanSUV implements IVehicle {

    @Override
    public void showVehicleInfo() {
        System.out.println("I am a German SUV");
    }
}
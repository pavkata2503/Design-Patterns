package products;

import interfaces.IVehicle;

public class JapaneseSUV implements IVehicle {

    @Override
    public void showVehicleInfo() {
        System.out.println("I am a Japanese SUV");
    }
}
package products;

import interfaces.IVehicle;

public class JapaneseSedan implements IVehicle {

    @Override
    public void showVehicleInfo() {
        System.out.println("I am a Japanese sedan");
    }
}
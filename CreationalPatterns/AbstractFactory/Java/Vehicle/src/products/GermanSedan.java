package products;

import interfaces.IVehicle;

public class GermanSedan implements IVehicle {

    @Override
    public void showVehicleInfo() {
        System.out.println("I am a German sedan");
    }
}
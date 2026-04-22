package products;

import interfaces.IVehicle;

public class ItalianSUV implements IVehicle {

    @Override
    public void showVehicleInfo() {
        System.out.println("I am an Italian SUV");
    }
}
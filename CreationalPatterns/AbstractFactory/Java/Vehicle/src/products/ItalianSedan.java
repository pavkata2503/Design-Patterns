package products;

import interfaces.IVehicle;

public class ItalianSedan implements IVehicle {

    @Override
    public void showVehicleInfo() {
        System.out.println("I am an Italian sedan");
    }
}
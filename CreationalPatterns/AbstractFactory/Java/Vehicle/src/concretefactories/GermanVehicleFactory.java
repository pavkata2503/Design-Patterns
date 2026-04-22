package concretefactories;

import interfaces.IVehicle;
import interfaces.IVehicleFactory;
import products.GermanSUV;
import products.GermanSedan;
import products.GermanSportsCar;

public class GermanVehicleFactory implements IVehicleFactory {

    @Override
    public IVehicle createSedan() {
        return new GermanSedan();
    }

    @Override
    public IVehicle createSUV() {
        return new GermanSUV();
    }

    @Override
    public IVehicle createSportsCar() {
        return new GermanSportsCar();
    }
}
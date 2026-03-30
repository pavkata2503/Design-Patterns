package concretefactories;

import interfaces.IVehicle;
import interfaces.IVehicleFactory;
import products.ItalianSUV;
import products.ItalianSedan;
import products.ItalianSportsCar;

public class ItalianVehicleFactory implements IVehicleFactory {

    @Override
    public IVehicle createSedan() {
        return new ItalianSedan();
    }

    @Override
    public IVehicle createSUV() {
        return new ItalianSUV();
    }

    @Override
    public IVehicle createSportsCar() {
        return new ItalianSportsCar();
    }
}
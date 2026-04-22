package concretefactories;

import interfaces.IVehicle;
import interfaces.IVehicleFactory;
import products.JapaneseSUV;
import products.JapaneseSedan;
import products.JapaneseSportsCar;

public class JapaneseVehicleFactory implements IVehicleFactory {

    @Override
    public IVehicle createSedan() {
        return new JapaneseSedan();
    }

    @Override
    public IVehicle createSUV() {
        return new JapaneseSUV();
    }

    @Override
    public IVehicle createSportsCar() {
        return new JapaneseSportsCar();
    }
}
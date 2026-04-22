import java.util.Scanner;

import concretefactories.GermanVehicleFactory;
import concretefactories.ItalianVehicleFactory;
import concretefactories.JapaneseVehicleFactory;
import interfaces.IVehicle;
import interfaces.IVehicleFactory;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Please select vehicle origin:");
        System.out.println("[1] German, [2] Japanese, [3] Italian");

        int vehicleOrigin = scanner.nextInt();
        IVehicleFactory vehicleFactory = null;

        switch (vehicleOrigin) {
            case 1:
                vehicleFactory = new GermanVehicleFactory();
                break;
            case 2:
                vehicleFactory = new JapaneseVehicleFactory();
                break;
            case 3:
                vehicleFactory = new ItalianVehicleFactory();
                break;
            default:
                System.out.println("Invalid vehicle origin.");
                scanner.close();
                return;
        }

        System.out.println("Please select vehicle type:");
        System.out.println("[1] Sedan, [2] SUV, [3] Sports Car");

        int vehicleType = scanner.nextInt();
        IVehicle vehicle = null;

        switch (vehicleType) {
            case 1:
                vehicle = vehicleFactory.createSedan();
                break;
            case 2:
                vehicle = vehicleFactory.createSUV();
                break;
            case 3:
                vehicle = vehicleFactory.createSportsCar();
                break;
            default:
                System.out.println("Invalid vehicle type.");
                scanner.close();
                return;
        }

        vehicle.showVehicleInfo();
        scanner.close();
    }

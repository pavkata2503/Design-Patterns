import creators.CarCreator;
import creators.IVehicleCreator;
import creators.MotorcycleCreator;
import creators.TruckCreator;
import extensions.StringExtensions;
import products.Vehicle;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        try {
            IVehicleCreator[] vehicleCreators = new IVehicleCreator[] {
                    new CarCreator(),
                    new MotorcycleCreator(),
                    new TruckCreator()
            };

            List<Vehicle> vehicles = new ArrayList<>();
            Scanner scanner = new Scanner(System.in);

            for (IVehicleCreator vehicleCreator : vehicleCreators) {
                String vehicleTypeFromCreator = vehicleCreator.getClass().getSimpleName()
                        .replace("Creator", "");

                vehicleTypeFromCreator = StringExtensions.splitPascalCaseString(vehicleTypeFromCreator);

                System.out.println("Enter vehicle details for type " + vehicleTypeFromCreator + ": ");

                System.out.print("Enter model: ");
                String vehicleModel = scanner.nextLine();

                System.out.print("Enter max speed: ");
                int vehicleMaxSpeed = Integer.parseInt(scanner.nextLine());

                System.out.print("Enter price: ");
                double vehiclePrice = Double.parseDouble(scanner.nextLine());

                Vehicle createdVehicle = vehicleCreator.createVehicle(
                        vehicleModel,
                        vehicleMaxSpeed,
                        vehiclePrice
                );

                vehicles.add(createdVehicle);
            }

            for (Vehicle vehicle : vehicles) {
                System.out.println(vehicle.toString());
            }

            scanner.close();
        } catch (NumberFormatException exception) {
            System.out.println("Aborting! Found entry with wrong format!");
        } catch (Exception exception) {
            System.out.println(exception.getMessage());
        }
    }
}
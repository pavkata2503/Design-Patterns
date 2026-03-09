package products;

import extensions.StringExtensions;

public abstract class Vehicle {
    private static final int VEHICLE_MINIMUM_SPEED = 20;
    private static final int VEHICLE_MAXIMUM_SPEED = 400;

    private static final double VEHICLE_MINIMUM_PRICE = 1000;
    private static final double VEHICLE_MAXIMUM_PRICE = 1000000;

    private static final String NULL_OR_WHITE_SPACE_VEHICLE_MODEL_ERROR_MESSAGE = "The %s's model cannot be empty!";
    private static final String VEHICLE_SPEED_OUT_OF_RANGE_ERROR_MESSAGE = "The vehicle's speed must be between %d and %d!";
    private static final String VEHICLE_PRICE_OUT_OF_RANGE_ERROR_MESSAGE = "The vehicle's price must be between %.0f and %.0f!";

    private String model;
    private int maxSpeed;
    private double price;

    protected Vehicle(String model, int maxSpeed, double price) {
        setModel(model);
        setMaxSpeed(maxSpeed);
        setPrice(price);
    }

    public String getModel() {
        return model;
    }

    public void setModel(String model) {
        if (model == null || model.trim().isEmpty()) {
            throw new IllegalArgumentException(
                    String.format(
                            NULL_OR_WHITE_SPACE_VEHICLE_MODEL_ERROR_MESSAGE,
                            StringExtensions.splitPascalCaseString(this.getClass().getSimpleName())
                    )
            );
        }

        this.model = model;
    }

    public int getMaxSpeed() {
        return maxSpeed;
    }

    public void setMaxSpeed(int maxSpeed) {
        if (maxSpeed < VEHICLE_MINIMUM_SPEED || maxSpeed > VEHICLE_MAXIMUM_SPEED) {
            throw new IllegalArgumentException(
                    String.format(
                            VEHICLE_SPEED_OUT_OF_RANGE_ERROR_MESSAGE,
                            VEHICLE_MINIMUM_SPEED,
                            VEHICLE_MAXIMUM_SPEED
                    )
            );
        }

        this.maxSpeed = maxSpeed;
    }

    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        if (price < VEHICLE_MINIMUM_PRICE || price > VEHICLE_MAXIMUM_PRICE) {
            throw new IllegalArgumentException(
                    String.format(
                            VEHICLE_PRICE_OUT_OF_RANGE_ERROR_MESSAGE,
                            VEHICLE_MINIMUM_PRICE,
                            VEHICLE_MAXIMUM_PRICE
                    )
            );
        }

        this.price = price;
    }

    @Override
    public String toString() {
        return "Vehicle: " + StringExtensions.splitPascalCaseString(this.getClass().getSimpleName()) +
                " with model: " + model +
                ", max speed: " + maxSpeed +
                " and price: " + price;
    }
}
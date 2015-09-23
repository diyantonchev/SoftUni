package oneLevShop.products;

import oneLevShop.enums.AgeRestriction;
import oneLevShop.interfaces.Buyable;

public abstract class Product implements Buyable {
    private String name;
    private double price;
    private double quantity;
    private AgeRestriction ageRestriction;



    public Product(String name, double price, double quantity, AgeRestriction ageRestriction) {
        this.setName(name);
        this.setPrice(price);
        this.setQuantity(quantity);
        this.setAgeRestriction(ageRestriction);
    }


    public String getName() {
        return this.name;
    }

    public void setName(String name) {

        if (name.isEmpty() || name == null) {

            throw new IllegalArgumentException("Product name cannot be null or empty.");
        }
        this.name = name;
    }

    public double getPrice() {
        return this.price;
    }

    public void setPrice(double price) {
        if (price < 0){
            throw new IllegalArgumentException("Product price cannot be negative");
        }

        this.price = price;
    }

    public double getQuantity() {
        return quantity;
    }

    public void setQuantity(double quantity) {
        if (quantity < 0){
            throw new IllegalArgumentException("Quantity cannot be negative");
        }
        this.quantity = quantity;
    }

    public AgeRestriction getAgeRestriction() {
        return ageRestriction;
    }

    public void setAgeRestriction(AgeRestriction ageRestriction) {
        this.ageRestriction = ageRestriction;
    }
}

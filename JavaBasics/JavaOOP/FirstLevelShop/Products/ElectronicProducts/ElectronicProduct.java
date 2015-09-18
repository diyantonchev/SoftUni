package FirstLevelShop.Products.ElectronicProducts;

import FirstLevelShop.Enums.AgeRestriction;
import FirstLevelShop.Products.Product;

public abstract class ElectronicProduct extends Product {

    private int guaranteePeriod;

    public ElectronicProduct(String name, double price, double quantity, AgeRestriction ageRestriction) {
        super(name, price, quantity, ageRestriction);

    }

    public int getGuaranteePeriod() {
        return this.guaranteePeriod;
    }

    public void setGuaranteePeriod(int guaranteePeriod) {
        if (guaranteePeriod < 0) {
            throw new IllegalArgumentException("Guarantee period cannot be negative");
        }
        this.guaranteePeriod = guaranteePeriod;
    }
}

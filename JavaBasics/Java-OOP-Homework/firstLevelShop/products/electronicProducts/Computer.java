package firstLevelShop.products.electronicProducts;

import firstLevelShop.enums.AgeRestriction;

public class Computer extends ElectronicProduct {

    private final int GuaranteePeriodInMonths = 24;
    private final int MinPromotionalQuantity = 1000;

    public Computer(String name, double price, double quantity, AgeRestriction ageRestriction) {
        super(name, price, quantity, ageRestriction);
        super.setGuaranteePeriod(GuaranteePeriodInMonths);
        this.checkGuaranteePeriod();
    }

    private void checkGuaranteePeriod() {
        if (super.getQuantity() > MinPromotionalQuantity) {
            double newPrice = super.getPrice() * 0.95;
            super.setPrice(newPrice);
        }
    }
}

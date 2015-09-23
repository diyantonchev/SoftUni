package oneLevShop.products.electronicProducts;

import oneLevShop.enums.AgeRestriction;

public class Appliance extends ElectronicProduct {

    private final int GuaranteePeriodInMonths = 24;
    private final int MinPromotionalQuantity = 50;

    public Appliance(String name, double price, double quantity, AgeRestriction ageRestriction) {
        super(name, price, quantity, ageRestriction);
        super.setGuaranteePeriod(GuaranteePeriodInMonths);
        this.checkGuaranteePeriod();
    }

    private void checkGuaranteePeriod() {
        if (super.getQuantity() < MinPromotionalQuantity) {
            double newPrice = super.getPrice() * 1.05;
            super.setPrice(newPrice);
        }
    }
}

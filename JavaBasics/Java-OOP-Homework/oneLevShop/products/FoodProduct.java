package oneLevShop.products;

import oneLevShop.enums.AgeRestriction;
import oneLevShop.interfaces.Expirable;

import java.time.LocalDate;
import java.time.temporal.ChronoUnit;

public class FoodProduct extends Product implements Expirable {

    private LocalDate expirationDate;

    public FoodProduct(String name, double price, double quantity, AgeRestriction ageRestriction) {
        super(name, price, quantity, ageRestriction);
    }

    public FoodProduct(String name, double price, double quantity, AgeRestriction ageRestriction, LocalDate expirationDate) {
        this(name, price, quantity, ageRestriction);

        this.setExpirationDate(expirationDate);
        this.checkExpirationDate(super.getPrice());
    }

    @Override
    public LocalDate getExpirationDate() {
        return this.expirationDate;
    }

    public void setExpirationDate(LocalDate expirationDate) {
        this.expirationDate = expirationDate;
    }

    public void checkExpirationDate(double price) {
        LocalDate currentDate = LocalDate.now();
        LocalDate expirationDate = this.expirationDate;
        long daysTillExpirationDate = ChronoUnit.DAYS.between(currentDate, expirationDate);
        if (daysTillExpirationDate <= 15) {
            double newPrice = price * 0.7;
            super.setPrice(newPrice);
        } else {
            super.setPrice(price);
        }
    }
}

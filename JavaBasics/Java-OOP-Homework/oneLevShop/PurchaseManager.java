package oneLevShop;

import oneLevShop.enums.AgeRestriction;
import oneLevShop.exceptions.NoPermissionException;
import oneLevShop.exceptions.NotEnoughMoneyException;
import oneLevShop.exceptions.ProductExpiredException;
import oneLevShop.exceptions.ProductOutOfStockException;
import oneLevShop.interfaces.Expirable;
import oneLevShop.products.FoodProduct;
import oneLevShop.products.Product;

import java.time.LocalDate;
import java.time.temporal.ChronoUnit;

public class PurchaseManager {

    static {

    }

    public static void processPurchase(Customer customer, Product product) throws ProductOutOfStockException, ProductExpiredException, NotEnoughMoneyException, NoPermissionException {

        productOutOfStockCheck(product);
        if (product instanceof Expirable && ((Expirable) product).getExpirationDate() != null) {
            productExpiredCheck((FoodProduct) product);
        }
        enoughBalanceCheck(customer.getBalance(), product.getPrice());
        if (product.getAgeRestriction() != AgeRestriction.None) {
            permissionCheck(product.getAgeRestriction(), customer.getAge());
        }

        double reducedBalance = customer.getBalance() - product.getPrice();
        customer.setBalance(reducedBalance);

        double reducedQuantity = product.getQuantity() - 1;
        product.setQuantity(reducedQuantity);
    }

    private static void productOutOfStockCheck(Product product) throws ProductOutOfStockException {
        if (product.getQuantity() == 0) {
            throw new ProductOutOfStockException(Messages.OutOfStockMessage);
        }
    }

    private static void enoughBalanceCheck(double balance, double price) throws NotEnoughMoneyException {
        if (price > balance) {
            throw new NotEnoughMoneyException(Messages.NotEnoughMoneyMessage);
        }
    }

    private static void productExpiredCheck(FoodProduct product) throws ProductExpiredException {
        LocalDate currentDate = LocalDate.now();
        boolean isExpired = ChronoUnit.DAYS.between(currentDate,product.getExpirationDate()) <= 0;
        if (isExpired) {
            throw new ProductExpiredException(Messages.ProductExpiredMessage);
        }
    }

    private static void permissionCheck(AgeRestriction ageRestriction, int age) throws NoPermissionException {
        boolean isTeenager = age < 18;
        boolean isAdult = age >= 18;
        if ((isTeenager && ageRestriction == AgeRestriction.Adult) || (isAdult && ageRestriction == AgeRestriction.Teenager)) {
            throw new NoPermissionException(Messages.NoPermissionMessage);
        }
    }
}
package FirstLevelShop;

import FirstLevelShop.Enums.AgeRestriction;
import FirstLevelShop.Exceptions.NoPermissionException;
import FirstLevelShop.Exceptions.NotEnoughMoneyException;
import FirstLevelShop.Exceptions.ProductExpiredException;
import FirstLevelShop.Exceptions.ProductOutOfStockException;
import FirstLevelShop.Interfaces.Expirable;
import FirstLevelShop.Products.ElectronicProducts.Appliance;
import FirstLevelShop.Products.ElectronicProducts.Computer;
import FirstLevelShop.Products.FoodProduct;
import FirstLevelShop.Products.Product;
import com.sun.org.apache.xpath.internal.SourceTree;

import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

public class ShopMain {
    public static void main(String[] args) {

        FoodProduct cigars = new FoodProduct("420 Blaze it fgt", 6.90, 1400, AgeRestriction.Adult);

        try {
            Customer pecata = new Customer("Pecata", 17, 30.00);
            PurchaseManager.processPurchase(pecata, cigars);
        } catch (NoPermissionException | NotEnoughMoneyException | ProductExpiredException | ProductOutOfStockException ex) {
            System.err.println(ex.getMessage());
        }

        try {
            Customer gopeto = new Customer("Gopeto", 18, 0.44);
            PurchaseManager.processPurchase(gopeto, cigars);
        } catch (NoPermissionException | NotEnoughMoneyException | ProductExpiredException | ProductOutOfStockException ex) {
            System.err.println(ex.getMessage());
        }

        LocalDate breadExpirationDate = LocalDate.of(2015, 11, 23);
        FoodProduct bread = new FoodProduct("Bread", 1, 10, AgeRestriction.None, breadExpirationDate);
        LocalDate milkExpirationDate = LocalDate.of(2015, 12, 25);
        FoodProduct milk = new FoodProduct("Milk", 2, 50, AgeRestriction.None, milkExpirationDate);
        Computer computer = new Computer("Pravec", 888.88, 1, AgeRestriction.None);
        Appliance appliance = new Appliance("Gadget", 99.99, 2, AgeRestriction.Adult);
        LocalDate salamExpirationDate = LocalDate.of(2015, 9, 23);
        FoodProduct salam = new FoodProduct("Salam", 10, 1, AgeRestriction.None, salamExpirationDate);

        ArrayList<Product> products = new ArrayList<Product>() {{
            add(computer);
            add(appliance);
            add(salam);
        }};

        String ProductWithTheSoonestDateOfExpiration = products.stream()
                .filter(p -> p instanceof Expirable)
                .map(p -> (Expirable) p)
                .sorted((p1, p2) -> p1.getExpirationDate().compareTo(p2.getExpirationDate()))
                .map(p -> (Product) p)
                .findFirst().get().getName();

        System.out.println(ProductWithTheSoonestDateOfExpiration);

         products.stream()
                .filter(product -> product.getAgeRestriction() != AgeRestriction.None)
                .sorted((p1, p2) -> Double.compare(p1.getPrice(), p2.getPrice()))
                .collect(Collectors.toList())
                .forEach(product -> System.out.printf("%s price: %.2f%n", product.getName(), product.getPrice()));
    }
}

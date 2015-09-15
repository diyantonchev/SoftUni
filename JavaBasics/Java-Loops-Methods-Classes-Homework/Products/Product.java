package Products;

import com.sun.javaws.exceptions.InvalidArgumentException;

import java.math.BigDecimal;

public class Product {

    final BigDecimal MinPrice = BigDecimal.ZERO;

    private String name;
    private BigDecimal price;

    public Product(String name, BigDecimal price) throws InvalidArgumentException {
        this.setName(name);
        this.setPrice(price);
    }

    public String getName() {
        return this.name;
    }

    public void setName(String name) throws InvalidArgumentException {
        if (name == null || name.isEmpty()) {
            String[] message = {"Invalid product name", name};
            throw new InvalidArgumentException(message);
        }

        this.name = name;
    }

    public BigDecimal getPrice() {
        return price;
    }

    public void setPrice(BigDecimal price) throws InvalidArgumentException {
        if (price.compareTo(MinPrice) <= 0) {
            String[] message = {"Invalid product price", price.toString()};
            throw new InvalidArgumentException(message);
        }

        this.price = price;
    }

    public int compareTo(Product otherProduct) {

        BigDecimal otherProductPrice = otherProduct.getPrice();
        BigDecimal thisProductPrice = this.getPrice();
        return otherProductPrice.compareTo(thisProductPrice);
    }

    public String toString() {
        String product = String.format("%.2f %s", this.price, this.name);
        return product;
    }
}

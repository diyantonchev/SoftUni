package Products;

import com.sun.javaws.exceptions.InvalidArgumentException;

import java.io.*;
import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.HashMap;

public class OrderOfProducts {
    public static void main(String[] args) throws IOException, InvalidArgumentException {

        FileReader productReader = new FileReader("Products.txt");
        BufferedReader bufferedReader = new BufferedReader(productReader);

        ArrayList<Product> products = new ArrayList<>();
        String productArgs = bufferedReader.readLine();
        while (productArgs != null) {

            String[] currentProductParams = productArgs.split(" ");
            String productName = currentProductParams[0];
            BigDecimal productPrice = BigDecimal.valueOf(Double.parseDouble(currentProductParams[1]));

            Product currentProduct = new Product(productName, productPrice);
            products.add(currentProduct);

            productArgs = bufferedReader.readLine();
        }

        productReader.close();
        FileReader orderReader = new FileReader("Order.txt");
        bufferedReader = new BufferedReader(orderReader);

        HashMap<String, Double> orderHolder = new HashMap<>();
        String currentOrder = bufferedReader.readLine();
        while (currentOrder != null) {
            String[] orderParams = currentOrder.split(" ");
            String productName = orderParams[1];
            Double quantity = Double.parseDouble(orderParams[0]);

            if (!orderHolder.containsKey(productName)) {
                orderHolder.put(productName, quantity);
            } else {
                double newQuantity = orderHolder.get(productName) + quantity;
                orderHolder.replace(productName, newQuantity);
            }

            currentOrder = bufferedReader.readLine();
        }

        bufferedReader.close();
        orderReader.close();

        BigDecimal totalOrderPrice = new BigDecimal(0);
        for (String productName : orderHolder.keySet()) {
            for (Product product : products) {
                String currentProductName = product.getName();
                if (currentProductName.equals(productName)) {
                    BigDecimal currentProductPrice = product.getPrice();
                    BigDecimal quantity = BigDecimal.valueOf(orderHolder.get(productName));
                    BigDecimal orderPrice = currentProductPrice.multiply(quantity);
                    totalOrderPrice = totalOrderPrice.add(orderPrice);
                }
            }
        }

        FileWriter writer = new FileWriter("Output.txt");
        BufferedWriter bufferedWriter = new BufferedWriter(writer);
        bufferedWriter.write(totalOrderPrice.toString());
        bufferedWriter.close();
        writer.close();
    }
}
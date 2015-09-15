package Products;

import com.sun.javaws.exceptions.InvalidArgumentException;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.math.BigDecimal;
import java.util.ArrayList;

public class ListOfProducts {
    public static void main(String[] args) throws IOException, InvalidArgumentException {
        try {
            FileReader reader = new FileReader("Input.txt");
            BufferedReader bufferedReader = new BufferedReader(reader);

            ArrayList<Product> products = new ArrayList<>();
            String currentLine = bufferedReader.readLine();

            while (currentLine != null) {
                String[] productParams = currentLine.split(" ");
                String productName = productParams[0];
                BigDecimal productPrice = BigDecimal.valueOf(Double.parseDouble(productParams[1]));

                Product currentProduct = new Product(productName, productPrice);
                products.add(currentProduct);

                currentLine = bufferedReader.readLine();
            }

            bufferedReader.close();
            reader.close();

            boolean hasSwapped = true;
            while (hasSwapped) {
                hasSwapped = false;
                for (int index = 1; index < products.size(); index++) {
                    Product firstProduct = products.get(index - 1);
                    Product secondProduct = products.get(index);

                    if (firstProduct.compareTo(secondProduct) < 0) {
                        products.set(index - 1, secondProduct);
                        products.set(index, firstProduct);
                        hasSwapped = true;
                    }
                }
            }

            for (Product product : products) {
                System.out.println(product.toString());
            }
        } catch (IOException ex) {
            System.out.println(ex.getMessage());
        } catch (InvalidArgumentException ex) {
            System.out.println(ex.getMessage());
        }
    }
}

package JavaBasics_27May_2014;

import java.util.LinkedHashMap;
import java.util.Scanner;
import java.util.TreeMap;

public class _4Orders {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        LinkedHashMap<String, TreeMap<String, Integer>> aggregateOrders = new LinkedHashMap<>();
        int numberOfOrders = Integer.parseInt(inputScanner.nextLine());
        for (int i = 0; i < numberOfOrders; i++) {
            String[] order = inputScanner.nextLine().split("\\s+");
            String product = order[2];
            String customer = order[0];
            int amount = Integer.parseInt(order[1]);
            if (!aggregateOrders.containsKey(product)) {
                aggregateOrders.put(product, new TreeMap<>());
            }
            if (!aggregateOrders.get(product).containsKey(customer)) {
                aggregateOrders.get(product).put(customer, amount);
            } else {
                int newAmount = aggregateOrders.get(product).get(customer) + amount;
                aggregateOrders.get(product).put(customer, newAmount);
            }
        }

        StringBuilder output = new StringBuilder();
        for (String product : aggregateOrders.keySet()) {
            StringBuilder currentOrder = new StringBuilder();
            currentOrder.append(String.format("%s: ", product));
            for (String customer : aggregateOrders.get(product).keySet()) {
                currentOrder.append(String.format("%s %d, ", customer, aggregateOrders.get(product).get(customer)));
            }
            output.append(String.format("%s%n", currentOrder.toString().substring(0, currentOrder.length() - 2)));
            currentOrder.delete(0, currentOrder.length() - 1);
        }

        System.out.println(output.toString().trim());
    }
}

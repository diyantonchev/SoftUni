package JavaBasics_21Sept_2014Morning;

import java.util.LinkedHashMap;
import java.util.Scanner;
import java.util.TreeMap;

public class _04Nuts {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        TreeMap<String, LinkedHashMap<String, Integer>> companyOrders = new TreeMap<>();
        int numberOfOrders = Integer.parseInt(inputScanner.nextLine());
        for (int i = 0; i < numberOfOrders; i++) {
            String[] order = inputScanner.nextLine().split("\\s+");
            String company = order[0];
            String nut = order[1];
            int amount = Integer.parseInt(order[2].substring(0, order[2].length() - 2));
            if (!companyOrders.containsKey(company)) {
                companyOrders.put(company, new LinkedHashMap<>());
            }
            if (!companyOrders.get(company).containsKey(nut)) {
                companyOrders.get(company).put(nut, amount);
            } else {
                int newAmount = companyOrders.get(company).get(nut) + amount;
                companyOrders.get(company).put(nut, newAmount);
            }
        }

        StringBuilder output = new StringBuilder();
        for (String company : companyOrders.keySet()) {
            StringBuilder currentCompanyOrders = new StringBuilder();
            currentCompanyOrders.append(String.format("%s: ", company));
            for (String nut : companyOrders.get(company).keySet()) {
                currentCompanyOrders.append(
                        String.format("%s-%dkg, ", nut, companyOrders.get(company).get(nut)));
            }
            output.append(String.format(
                    "%s%n", currentCompanyOrders.toString().substring(0, currentCompanyOrders.length() - 2)));
            currentCompanyOrders.delete(0, currentCompanyOrders.length());
        }

        System.out.print(output.toString().trim());
    }
}

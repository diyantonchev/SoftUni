package JavaBasics_21Sept_2014Evening;

import java.util.LinkedHashMap;
import java.util.Scanner;
import java.util.TreeMap;

public class _04OfficeStuff {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);
        TreeMap<String, LinkedHashMap<String, Integer>> officeStuff = new TreeMap<>();
        int n = Integer.parseInt(inputScanner.nextLine());
        for (int i = 0; i < n; i++) {
            String[] info = inputScanner.nextLine().split("[\\s,|,-]+");
            String company = info[1];
            String product = info[3];
            int amount = Integer.parseInt(info[2]);
            if (!officeStuff.containsKey(company)) {
                officeStuff.put(company, new LinkedHashMap<>());
            }
            if (!officeStuff.get(company).containsKey(product)) {
                officeStuff.get(company).put(product, amount);
            } else {
                int newAmount = officeStuff.get(company).get(product) + amount;
                officeStuff.get(company).put(product, newAmount);
            }
        }

        StringBuilder output = new StringBuilder();
        for (String company : officeStuff.keySet()) {
            StringBuilder currentCompanyStuff = new StringBuilder();
            currentCompanyStuff.append(String.format("%s: ", company));
            for (String product : officeStuff.get(company).keySet()) {
                currentCompanyStuff.append(String.format("%s-%d, ", product, officeStuff.get(company).get(product)));
            }
            output.append(String.format("%s%n",currentCompanyStuff.toString().substring(0, currentCompanyStuff.length() - 2)));
            currentCompanyStuff.delete(0,currentCompanyStuff.length());
        }

        System.out.print(output.toString().trim());
    }
}

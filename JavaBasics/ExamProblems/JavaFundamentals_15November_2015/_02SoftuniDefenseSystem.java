package JavaFundamentals_15November_2015;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _02SoftuniDefenseSystem {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        StringBuilder text = new StringBuilder();
        String inputLine = inputScanner.nextLine();
        while (inputLine.compareTo("OK KoftiShans") != 0) {
            text.append(inputLine);
            text.append("\n");
            inputLine = inputScanner.nextLine();
        }

        Pattern pattern = Pattern.compile("([A-Z][a-z]+).*?([A-Z][a-z]*[A-Z]).*?([0-9]+L)");
        Matcher matcher = pattern.matcher(text);

        double softUniLiters = 0;
        while (matcher.find()) {
            String guest = matcher.group(1);
            double quantity = Double.parseDouble(matcher.group(3).substring(0, matcher.group(3).length() - 1));
            String drink = matcher.group(2).toLowerCase();
            softUniLiters += quantity;
            System.out.printf("%s brought %.0f liters of %s!%n", guest, quantity, drink);
        }

        softUniLiters *= 0.001;
        System.out.printf("%.3f softuni liters", softUniLiters);
    }
}

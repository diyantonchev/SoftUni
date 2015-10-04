package JavaBasics_26_May_2014;

import java.util.*;

public class _04CouplesFrequency {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);
        String[] numbers = inputScanner.nextLine().split("\\s+");
        LinkedHashMap<String, Integer> couples = new LinkedHashMap<>();
        for (int i = 0; i < numbers.length - 1; i++) {
            String currentCouple = numbers[i] + " " + numbers[i + 1];
            if (!couples.containsKey(currentCouple)) {
                couples.put(currentCouple, 1);
            } else {
                int newValue = couples.get(currentCouple) + 1;
                couples.put(currentCouple, newValue);
            }
        }

        double couplesCount = couples.values().stream().mapToDouble(Integer::doubleValue).sum();
        for (String couple : couples.keySet()) {
            double couplesFrequency = (double)couples.get(couple) * 100 / couplesCount;
            System.out.printf("%s -> %.2f%c%n",couple,couplesFrequency,'%');
        }
    }
}

package JavaBasics_07Jan_2015;

import java.util.ArrayList;
import java.util.Scanner;

public class _01Pyramid {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        int numberOfLines = Integer.parseInt(inputScanner.nextLine());
        ArrayList<Integer>[] pyramid = new ArrayList[numberOfLines];
        for (int i = 0; i < numberOfLines; i++) {
            pyramid[i] = new ArrayList<>();
            String[] currentLine = inputScanner.nextLine().split("[^\\d-]+");
            for (int j = 0; j < currentLine.length; j++) {
                if (!currentLine[j].isEmpty()) {
                    pyramid[i].add(Integer.parseInt(currentLine[j]));
                }
            }
        }

        ArrayList<Integer> numbers = new ArrayList<>();
        int number = pyramid[0].get(0);
        numbers.add(number);
        int closestNumber = Integer.MAX_VALUE;
        for (int i = 1; i < pyramid.length; i++) {
            boolean hasFound = false;
            ArrayList<Integer> currentLine = pyramid[i];
            for (int j = 0; j < currentLine.size(); j++) {
                int currentNumber = currentLine.get(j);
                if (currentNumber < closestNumber && currentNumber > number) {
                    closestNumber = currentNumber;
                    hasFound = true;
                }
            }
            if (hasFound) {
                numbers.add(closestNumber);
                number = closestNumber;
                closestNumber = Integer.MAX_VALUE;
            } else {
                number += 1;
            }
        }

        String numbersAsString = numbers.toString();
        System.out.printf("%s", numbersAsString.substring(1, numbersAsString.length() - 1));
    }
}

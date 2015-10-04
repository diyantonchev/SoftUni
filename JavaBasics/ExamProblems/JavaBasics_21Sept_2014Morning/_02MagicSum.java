package JavaBasics_21Sept_2014Morning;

import java.util.ArrayList;
import java.util.Scanner;

public class _02MagicSum {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);
        int divider = Integer.parseInt(inputScanner.nextLine());
        String inputLine = inputScanner.nextLine();
        ArrayList<Integer> numbers = new ArrayList<>();
        while (inputLine != "End") {
            try {
                int currentNumber = Integer.parseInt(inputLine);
                numbers.add(currentNumber);

            } catch (NumberFormatException ex) {
                break;
            }
            inputLine = inputScanner.nextLine();
        }

        StringBuilder output = new StringBuilder();
        int magicSum = Integer.MIN_VALUE;
        for (int i = 0; i < numbers.size(); i++) {
            int firstNumber = numbers.get(i);
            for (int j = i + 1; j < numbers.size(); j++) {
                int secondNumber = numbers.get(j);
                for (int k = j + 1; k < numbers.size(); k++) {
                    int thirdNumber = numbers.get(k);
                    int sum = firstNumber + secondNumber + thirdNumber;
                    if (sum % divider == 0 && sum > magicSum) {
                        magicSum = sum;
                        output.delete(0, output.length());
                        output.append(String.format("(%d + %d + %d) %s %d = 0",
                                firstNumber, secondNumber, thirdNumber, "%", divider));
                    }
                }
            }
        }

        if (output.toString().isEmpty()) {
            System.out.print("No");
        } else {
            System.out.print(output);
        }
    }
}

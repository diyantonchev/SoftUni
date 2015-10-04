package JavaBasics_27May_2014;

import java.math.BigDecimal;
import java.util.Arrays;
import java.util.Scanner;

public class _2ThreeLargestNumbers {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        int n = Integer.parseInt(inputScanner.nextLine());

        BigDecimal[] numbers = new BigDecimal[n];
        for (int i = 0; i < n; i++) {
            String currentNumber = inputScanner.nextLine();
            numbers[i] = new BigDecimal(currentNumber);
        }

        Arrays.sort(numbers);
        int length = Math.max(numbers.length - 3, 0);
        for (int i = numbers.length - 1; i >= length; i--) {
            System.out.println(numbers[i].toPlainString());
        }
    }
}

package JavaBasics_26_May_2014;

import java.util.Scanner;

public class _02PythagoreanNumbers {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);
        int n = Integer.parseInt(inputScanner.nextLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++) {
            numbers[i] = Integer.parseInt(inputScanner.nextLine());
        }

        StringBuilder output = new StringBuilder();
        for (int i = 0; i < numbers.length; i++) {
            int a = numbers[i];
            for (int j = 0; j < numbers.length; j++) {
                int b = numbers[j];
                if (a <= b) {
                    for (int k = 0; k < numbers.length; k++) {
                        int c = numbers[k];
                        if (a * a + b * b == c * c) {
                            output.append(String.format("%1$s*%1$s + %2$s*%2$s = %3$s*%3$s%n", a, b, c));
                        }
                    }
                }
            }
        }

        if (!output.toString().isEmpty()){
            System.out.print(output.toString().trim());
        } else {
            System.out.print("No");
        }

    }
}

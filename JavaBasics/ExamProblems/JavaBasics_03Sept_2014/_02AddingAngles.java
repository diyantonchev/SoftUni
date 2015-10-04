package JavaBasics_03Sept_2014;

import java.util.Scanner;

public class _02AddingAngles {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);
        inputScanner.nextLine();

        String[] numbersAsStrings = inputScanner.nextLine().split("\\s+");
        int[] numbers = parseToInt(numbersAsStrings);
        StringBuilder output = new StringBuilder();
        for (int i = 0; i < numbers.length; i++) {
            int a = numbers[i];
            for (int j = i + 1; j < numbers.length; j++) {
                int b = numbers[j];
                for (int k = j + 1; k < numbers.length; k++) {
                    int c = numbers[k];
                    int sum = a + b + c;
                    boolean isFullCircle = isMakeFullCircle(sum);
                    if (isFullCircle) {
                        output.append(String.format("%d + %d + %d = %d degrees%n", a, b, c, sum));
                    }
                }
            }
        }

        if (!output.toString().isEmpty()) {
            System.out.print(output.toString().trim());
        } else {
            System.out.print("No");
        }
    }

    private static boolean isMakeFullCircle(int sum) {
        boolean isCircle = sum % 360 == 0;
        if (isCircle) {
            return true;
        }
        return false;
    }

    private static int[] parseToInt(String[] numbersAsStrings) {
        int[] numbers = new int[numbersAsStrings.length];
        for (int i = 0; i < numbersAsStrings.length; i++) {
            numbers[i] = Integer.parseInt(numbersAsStrings[i]);
        }
        return numbers;
    }
}

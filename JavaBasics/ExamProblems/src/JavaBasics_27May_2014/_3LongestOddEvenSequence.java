package JavaBasics_27May_2014;

import java.util.Scanner;

public class _3LongestOddEvenSequence {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        String[] inputSequence = inputScanner.nextLine().trim().split("[^\\d]+");

        int[] numbers = new int[inputSequence.length - 1];
        for (int i = 1; i < inputSequence.length; i++) {
            numbers[i - 1] = Integer.parseInt(inputSequence[i]);
        }

        int bestLength = 0;
        int currentLength = 0;
        boolean shouldBeOdd = (numbers[0] % 2 != 0);
        for (int num : numbers) {
            boolean isOdd = num % 2 != 0;
            if (isOdd == shouldBeOdd || num == 0) {
                currentLength++;
            } else {
                shouldBeOdd = isOdd;
                currentLength = 1;
            }
            shouldBeOdd = !shouldBeOdd;
            if (currentLength > bestLength) {
                bestLength = currentLength;
            }
        }

        System.out.println(bestLength);
    }
}

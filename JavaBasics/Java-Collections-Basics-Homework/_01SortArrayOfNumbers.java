import java.util.Scanner;

public class _01SortArrayOfNumbers {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        int size = Integer.parseInt(inputScanner.nextLine());
        int[] numbers = new int[size];
        String[] inputLine = inputScanner.nextLine().split(" ");
        fillArray(numbers, inputLine);
        sort(numbers);
        print(numbers);
    }

    private static void fillArray(int[] numbers, String[] inputLine) {
        for (int i = 0; i < inputLine.length; i++) {
            numbers[i] = Integer.parseInt(inputLine[i]);
        }
    }

    private static void sort(int[] numbers) {
        boolean isSwapped = true;
        while (isSwapped) {
            isSwapped = false;
            for (int i = 1; i < numbers.length; i++) {
                int firstElement = numbers[i - 1];
                int secondElement = numbers[i];
                if (firstElement > secondElement) {
                    numbers[i - 1] = secondElement;
                    numbers[i] = firstElement;
                    isSwapped = true;
                }
            }
        }
    }

    private static void print(int[] numbers) {
        for (int i = 0; i < numbers.length; i++) {
            System.out.printf("%s ",numbers[i]);
        }
    }
}

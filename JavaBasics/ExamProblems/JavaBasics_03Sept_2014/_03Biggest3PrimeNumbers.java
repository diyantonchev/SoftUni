package JavaBasics_03Sept_2014;

import java.util.Collections;
import java.util.Scanner;
import java.util.TreeSet;

public class _03Biggest3PrimeNumbers {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);
        String[] numbersAsStrings = inputScanner.nextLine().split("[\\s()]+");

        TreeSet<Integer> numbers = new TreeSet<>(Collections.reverseOrder());
        for (int i = 1; i < numbersAsStrings.length; i++) {
            int number = Integer.parseInt(numbersAsStrings[i]);
            numbers.add(number);
        }

        int sum = 0;
        int primeCounter = 0;
        for (Integer number : numbers) {

            if (number <= 1 || primeCounter == 3) {
                break;
            }

            boolean isPrime = isPrimeCheck(number);

            if (isPrime) {
                sum += number;
                primeCounter++;
            }
        }

        if (primeCounter < 3){
            System.out.print("No");
        } else {
            System.out.print(sum);
        }
    }

    private static boolean isPrimeCheck(Integer number) {
        for (int i = 2; i < number; i++) {
            if (number % i == 0) {
                return false;
            }
        }
        return true;
    }
}

import java.util.ArrayList;
import java.util.Scanner;

public class _01SymmetricNumbersInRange {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        int start = inputScanner.nextInt();
        int end = inputScanner.nextInt();

        ArrayList symmetricNumbers = new ArrayList<Integer>();

        for (int number = start; number <= end; number++) {

            String numberToString = Integer.toString(number);
            String reversedNumber = new StringBuilder(numberToString).reverse().toString();
            boolean isSymmetric = numberToString.equals(reversedNumber);

            if (isSymmetric) {
                symmetricNumbers.add(number);
            }
        }

        System.out.println(symmetricNumbers);
    }
}

import java.util.Scanner;

public class _04TheSmallestOf3Numbers {
    public static void main(String[] args) {

        Scanner inputScanner = new Scanner(System.in);

        double firstNumber = inputScanner.nextDouble();
        double secondNumber = inputScanner.nextDouble();
        double thirdNumber = inputScanner.nextDouble();

        double smallestNumber = findTheSmallestNumber(firstNumber, secondNumber, thirdNumber);

        System.out.println(smallestNumber);
    }

    private static double findTheSmallestNumber(double firstNumber, double secondNumber, double thirdNumber) {
        double smallest = firstNumber;
        smallest = (smallest < secondNumber) ? smallest : secondNumber;
        smallest = (smallest < thirdNumber) ? smallest : thirdNumber;

        return smallest;
    }
}

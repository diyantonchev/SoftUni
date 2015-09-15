import java.util.Scanner;

public class _05AngleUnitConverter {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        final String[] measures = {"deg", "rad"};
        int inputLines = Integer.parseInt(inputScanner.nextLine());

        for (int i = 0; i < inputLines; i++) {
            String[] input = inputScanner.nextLine().split(" ");
            double number = Double.parseDouble(input[0]);
            String measure = input[1];

            if (measure.equals(measures[0])) {
                double radians = convertToRadians(number);
                System.out.printf("%f rad", radians);
                System.out.println();
            } else {
                double degrees = convertToDegrees(number);
                System.out.printf("%f deg", degrees);
                System.out.println();
            }
        }
    }

    private static double convertToDegrees(double radians) {
        double degrees = radians * (180 / Math.PI);

        return degrees;
    }

    private static double convertToRadians(double degrees) {
        double radians = degrees * (Math.PI / 180);

        return radians;
    }
}

package JavaBasics_21Sept_2014Evening;

import java.util.Arrays;
import java.util.InputMismatchException;
import java.util.Scanner;

public class _2PossibleTriangles {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);
        StringBuilder output = new StringBuilder();
        while (true) {
            try {
                double[] sides = new double[]{
                        inputScanner.nextDouble(),
                        inputScanner.nextDouble(),
                        inputScanner.nextDouble(),
                };
                Arrays.sort(sides);
                double a = sides[0];
                double b = sides[1];
                double c = sides[2];
                boolean isValidTriangle = a + b > c;
                if (isValidTriangle) {
                    output.append(String.format("%.2f+%.2f>%.2f%n", a, b, c));
                }
                inputScanner.nextLine();

            } catch (InputMismatchException exception) {
                break;
            }
        }

        if (output.toString().isEmpty()){
            System.out.print("No");
        } else {
            System.out.print(output.toString().trim());
        }
    }
}

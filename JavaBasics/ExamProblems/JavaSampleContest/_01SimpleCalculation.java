package JavaSampleContest;

import java.util.Scanner;

public class _01SimpleCalculation {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);
        double x = Double.parseDouble(inputScanner.nextLine());
        double y = Double.parseDouble(inputScanner.nextLine());
        if (x == 0 && y == 0) {
            System.out.println(0);
        } else if (y == 0 && x != 0) {
            System.out.println(6);
        } else if (y != 0 && x == 0) {
            System.out.println(5);
        } else if (x > 0 && y > 0) {
            System.out.println(1);
        } else if (x < 0 && y > 0) {
            System.out.println(2);
        } else if (x < 0 && y < 0) {
            System.out.println(3);
        } else {
            System.out.println(4);
        }
    }
}

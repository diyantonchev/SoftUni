import java.util.Scanner;

public class _01RectangleArea {

    public static void main(String[] args) {

        Scanner inputScanner = new Scanner(System.in);

        double width = inputScanner.nextDouble();
        double height = inputScanner.nextDouble();
        double area = calculateRectangleArea(width, height);

        System.out.println(area);
    }

    private static double calculateRectangleArea(double width, double height) {

        return width * height;
    }
}
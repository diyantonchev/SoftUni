import java.awt.*;
import java.util.Scanner;

public class _02TriangleArea {
    public static void main(String[] args) {

        Scanner inputScanner = new Scanner(System.in);

        Point pointA = new Point();
        Point pointB = new Point();
        Point pointC = new Point();

        for (int i = 0; i < 3; i++) {
            double x = inputScanner.nextDouble();
            double y = inputScanner.nextDouble();

            if (i == 0) {
                pointA.setLocation(x, y);
            } else if (i == 1) {
                pointB.setLocation(x, y);
            } else {
                pointC.setLocation(x, y);
            }
        }

        double area = calculateArea(pointA, pointB, pointC);

        System.out.printf("%.0f", area);
    }

    private static double calculateArea(Point a, Point b, Point c) {
        double area = Math.abs(
                        (a.getX() * (b.getY() - c.getY())
                        + b.getX() * (c.getY() - a.getY()) +
                        c.getX() * (a.getY() - b.getY()))
                        / 2);

        return area;
    }
}

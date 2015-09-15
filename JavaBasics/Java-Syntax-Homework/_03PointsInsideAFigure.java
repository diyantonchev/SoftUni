import java.awt.*;
import java.util.Scanner;

public class _03PointsInsideAFigure {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        double x = inputScanner.nextDouble();
        double y = inputScanner.nextDouble();

        boolean isInside = isInsideUpperFigure(x, y) || isInsideLeftFigure(x, y) || isInsideRightFigure(x, y);

        if (isInside){
            System.out.println("Inside");
        } else {
            System.out.println("Outside");
        }

    }

    private static boolean isInsideUpperFigure(double x, double y) {
        double minX = 12.5;
        double maxX = 22.5;

        double minY = 6;
        double maxY = 8.5;

        boolean isInside = (x >= minX && x <= maxX) &&
                (y >= minY && y <= maxY);

        return isInside;
    }

    private static boolean isInsideLeftFigure(double x, double y) {
        double minX = 12.5;
        double maxX = 17.5;

        double minY = 8.5;
        double maxY = 13.5;

        boolean isInside = (x >= minX && x <= maxX) &&
                (y >= minY && y <= maxY);

        return isInside;
    }

    private static boolean isInsideRightFigure(double x, double y) {
        double minX = 20;
        double maxX = 22.5;

        double minY = 8.5;
        double maxY = 13.5;

        boolean isInside = (x >= minX && x <= maxX) &&
                (y >= minY && y <= maxY);

        return isInside;

    }
}



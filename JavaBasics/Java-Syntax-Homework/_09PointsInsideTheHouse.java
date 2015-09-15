import java.util.Scanner;

public class _09PointsInsideTheHouse {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        double pointX = inputScanner.nextDouble();
        double pointY = inputScanner.nextDouble();

        boolean isInside = isInsideTheHouse(pointX,pointY);

        String result = isInside ? "Inside" : "Outside";

        System.out.println(result);
    }

    private static boolean isInsideTheHouse(double x, double y) {

        boolean isInRoof = isInRoof(x, y);
        boolean isInLeftSide = (y >= 8.5 && y <= 13.5) && (x >= 12.5 && x <= 17.5);
        boolean isInRightSide = (y >= 8.5 && y <= 13.5) && (x >= 20 && x <= 22.5);

        boolean isInside = isInRoof || isInLeftSide || isInRightSide;

        return isInside;
    }

    private static boolean isInRoof(double x, double y) {
        double aX = 12.5;
        double aY = 8.5;
        double bX = 22.5;
        double bY = 8.5;
        double cX = 17.5;
        double cY = 3.5;

        boolean isUnderLeftSide = (sign(x, y, aX, aY, cX, cY) < 0);
        boolean isUnderRigthSide = (sign(x, y, cX, cY, bX, bY) < 0);
        boolean isAboveHorizontalSide = (sign(x, y, bX, bY, aX, aY) < 0);

        boolean isInRoof = (isUnderLeftSide == isUnderRigthSide) && (isUnderRigthSide == isAboveHorizontalSide);

        return isInRoof;
    }

    private static double sign(double firstPointX, double firstPointY, double secondPointX, double secondPointY, double thirdPointX, double thirdPointY) {
        return (firstPointX - thirdPointX) * (secondPointY - thirdPointY) - (secondPointX - thirdPointX) * (firstPointY - thirdPointY);
    }
}

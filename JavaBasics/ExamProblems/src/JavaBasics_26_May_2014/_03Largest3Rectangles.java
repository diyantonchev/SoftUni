package JavaBasics_26_May_2014;

import java.util.ArrayList;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _03Largest3Rectangles {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);
        String input = inputScanner.nextLine();
        Pattern rectanglesPattern = Pattern.compile("\\[\\s*\\d+\\s*x\\s*\\d+\\s*\\]");
        Matcher rectanglesMatcher = rectanglesPattern.matcher(input);
        ArrayList<String> rectangles = new ArrayList<>();
        while (rectanglesMatcher.find()) {
            rectangles.add(rectanglesMatcher.group());
        }

        int bestSum = Integer.MIN_VALUE;
        for (int i = 0; i < rectangles.size() - 2; i++) {
            String[] firstRectangle = rectangles.get(i).trim().split("[^\\d]");
            String[] secondRectangle = rectangles.get(i + 1).trim().split("[^\\d]");
            String[] thirdRectangle = rectangles.get(i + 2).trim().split("[^\\d]");
            int firstRectArea = getArea(firstRectangle);
            int secondRectArea = getArea(secondRectangle);
            int thirdRectArea = getArea(thirdRectangle);
            int sum = firstRectArea + secondRectArea + thirdRectArea;
            if (sum > bestSum) {
                bestSum = sum;
            }
        }

        System.out.println(bestSum);
    }

    private static int getArea(String[] rectangle) {
        ArrayList<Integer> rectangleCoordinates = new ArrayList<>();
        for (int i = 0; i < rectangle.length; i++) {
            if (!rectangle[i].isEmpty()){
                rectangleCoordinates.add(Integer.parseInt(rectangle[i]));
            }
        }

        int area = rectangleCoordinates.get(0) * rectangleCoordinates.get(1);
        return area;
    }
}

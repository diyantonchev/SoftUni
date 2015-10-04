package JavaBasics_07Jan_2015;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _02TerroristsWin {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);
        String input = inputScanner.nextLine();

        Pattern bombPattern = Pattern.compile("\\|[^\\|]*\\|");
        Matcher bombMatcher = bombPattern.matcher(input);
        StringBuilder output = new StringBuilder(input);
        while (bombMatcher.find()) {
            String bomb = bombMatcher.group();

            int sumOfChars = 0;
            for (int i = 1; i < bomb.length() - 1; i++) {
                sumOfChars += bomb.charAt(i);
            }

            String sumAsString = Integer.toString(sumOfChars);
            int power = Integer.parseInt(Character.toString(sumAsString.charAt(sumAsString.length() - 1)));

            int startIndex = Math.max(output.indexOf(bomb) - power, 0);
            int endIndex = Math.min(output.indexOf(bomb) + (bomb.length() - 1) + power, output.length() - 1);
            for (int i = startIndex; i <= endIndex; i++) {
                output.deleteCharAt(i);
                output.insert(i, '.');
            }
        }

        System.out.print(output);
    }
}

package JavaFundamentals_Retake_26Oct2015;

import java.util.ArrayList;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _02WeirdScript {
    public static void main(String[] args) {

        Scanner inputScanner = new Scanner(System.in);

        int keyNumber = Integer.parseInt(inputScanner.nextLine());
        int letterPosition = keyNumber % 26;
        if (letterPosition == 0) {
            letterPosition = 26;
        }
        char letter;
        boolean isLowerCase = isLowerCase(keyNumber);
        if (isLowerCase) {
            letter = (char) (letterPosition - 1 + 'a');
        } else {
            letter = (char) (letterPosition - 1 + 'A');
        }

        String inputLine = inputScanner.nextLine();
        StringBuilder text = new StringBuilder();
        while (!inputLine.equals("End")) {
            text.append(inputLine);
            inputLine = inputScanner.nextLine();
        }

        String key = String.format("%1$c%1$c", letter);
        ArrayList<String> sentences = new ArrayList<>();
        Pattern pattern = Pattern.compile(String.format("(%s)(.{0,50}?)(\\1)", key));
        Matcher matcher = pattern.matcher(text);
        while (matcher.find()) {
            sentences.add(matcher.group(2));
        }

        System.out.println(String.join("\r\n", sentences));
    }

    private static boolean isLowerCase(int keyNumber) {
        int number = keyNumber / 26;
        if (number == 4) {
            return false;
        }

        if (keyNumber >= 1 && keyNumber <= 26) {
            return true;
        } else if (number % 2 == 0) {
            return true;
        }

        return false;
    }
}


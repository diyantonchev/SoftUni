package JavaBasics_08February2015;

import java.util.Scanner;

public class _02LettersChangeNumbers {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        String[] strings = inputScanner.nextLine().split("\\s+");

        double result = 0;
        for (int i = 0; i < strings.length; i++) {
            char firstLetter = strings[i].charAt(0);
            int firstLetterPosition = getPositionInTheAlphabet(firstLetter);
            char lastLetter = strings[i].charAt(strings[i].length() - 1);
            int lastLetterPosition = getPositionInTheAlphabet(lastLetter);
            double number = Double.parseDouble(strings[i].substring(1,strings[i].length()-1));

            if (Character.isLowerCase(firstLetter)){
                number *= firstLetterPosition;
            } else {
                number /= firstLetterPosition;
            }
            if (Character.isLowerCase(lastLetter)) {
                number += lastLetterPosition;
            } else {
                number -= lastLetterPosition;
            }

            result += number;
        }

        System.out.printf("%.2f",result);
    }

    private static int getPositionInTheAlphabet(char letter) {
        int positionInAlphabet = Character.toUpperCase(letter) - 'A' + 1;
        return positionInAlphabet;
    }
}

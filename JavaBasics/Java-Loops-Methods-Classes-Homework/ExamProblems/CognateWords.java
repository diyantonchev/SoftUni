package ExamProblems;

import java.util.HashSet;
import java.util.Scanner;

public class Problem1_CognateWords {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        final String delimiter = "[^a-zA-Z]+";
        String[] words = inputScanner.nextLine().split(delimiter);

        HashSet<String> cognateWords = new HashSet<>();
        for (String firstWord : words) {
            StringBuilder concatenatedWords = new StringBuilder();
            for (String secondWord : words) {
                if (firstWord != secondWord) {
                    concatenatedWords.append(String.format("%s%s", firstWord, secondWord));
                } else {
                    continue;
                }

                for (String thirdWord : words) {
                    boolean isEqual = concatenatedWords.toString().equals(thirdWord);
                    if (isEqual) {
                        String cognateWord = String.format("%s|%s=%s", firstWord, secondWord, thirdWord);
                        cognateWords.add(cognateWord);
                    }
                }

                concatenatedWords.delete(0, concatenatedWords.length());
            }
        }

        if (cognateWords.isEmpty()) {
            System.out.println("No");
        } else {
            for (String cognateWord : cognateWords) {
                System.out.println(cognateWord);
            }
        }
    }
}
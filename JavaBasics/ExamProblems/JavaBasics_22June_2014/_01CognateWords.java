package JavaBasics_22June_2014;

import java.util.HashSet;
import java.util.Scanner;

public class _01CognateWords {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        String[] words = inputScanner.nextLine().split("[^a-zA-z]+");

        HashSet<String> cognateWords = new HashSet<>();
        for (String firstWord : words) {
            for (String secondWord : words) {
                if (secondWord != firstWord) {
                    String concatenatedWords = String.format("%s%s", firstWord, secondWord);
                    for (String word : words) {
                        if (concatenatedWords.equals(word)) {
                            cognateWords.add(String.format("%s|%s=%s", firstWord, secondWord, word));
                        }
                    }
                }
            }
        }

        if (!cognateWords.isEmpty()) {
            for (String cognateWord : cognateWords) {
                System.out.println(cognateWord);
            }
        } else {
            System.out.print("No");
        }
    }
}

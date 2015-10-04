package JavaBasics_21Sept_2014Morning;

import java.util.Scanner;

public class _03WeirdStrings {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        String text = inputScanner.nextLine();
        text = text.replaceAll("[\\\\/|\\s()]+", "");
        String[] words = text.split("[^a-zA-Z]+");

        StringBuilder output = new StringBuilder();
        int bestSum = 0;
        for (int i = 0; i < words.length - 1; i++) {
            String firstWord = words[i];
            String secondWord = words[i + 1];
            int firstWordSum = getWordSum(firstWord);
            int secondWordSum = getWordSum(secondWord);
            int sum = firstWordSum + secondWordSum;
            if (sum >= bestSum) {
                bestSum = sum;
                output.delete(0, output.length());
                output.append(String.format("%s%n%s", firstWord, secondWord));
            }
        }

        System.out.print(output);
    }

    private static int getWordSum(String word) {
        int sum = 0;
        for (int i = 0; i < word.length(); i++) {
            int weight = Character.toUpperCase(word.charAt(i)) - 'A' + 1;
            sum += weight;
        }

        return sum;
    }
}

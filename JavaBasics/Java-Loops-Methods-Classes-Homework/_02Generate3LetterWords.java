import java.util.Scanner;

public class _02Generate3LetterWords {
    public static void main(String[] args) {

        Scanner inputScanner = new Scanner(System.in);
        String letters = inputScanner.nextLine();

        StringBuilder allPossibleWords = new StringBuilder();
        char[] word = new char[3];

        for (int i = 0; i < letters.length(); i++) {
            word[0] = letters.charAt(i);
            for (int j = 0; j < letters.length(); j++) {
                word[1] = letters.charAt(j);
                for (int k = 0; k < letters.length(); k++) {
                    word[2] = letters.charAt(k);
                    allPossibleWords.append(word);
                    allPossibleWords.append(" ");
                }
            }
        }

        System.out.println(allPossibleWords);
    }
}

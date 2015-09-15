import java.util.Scanner;
import java.util.TreeSet;

public class _10ExtractAllUniqueWords {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        String[] text = inputScanner.nextLine().split("\\W+");

        TreeSet<String> uniqueWords = new TreeSet<>();
        fillSet(uniqueWords,text);
        for (String uniqueWord : uniqueWords) {
            System.out.printf("%s ",uniqueWord);
        }
    }

    private static void fillSet(TreeSet<String> set, String[] strings) {
        for (int i = 0; i < strings.length; i++) {
            String currentWord = strings[i].toLowerCase();
            set.add(currentWord);
        }
    }
}

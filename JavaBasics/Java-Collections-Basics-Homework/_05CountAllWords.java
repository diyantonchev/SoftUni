import java.util.Scanner;

public class _05CountAllWords {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        String[] words = inputScanner.nextLine().split("\\W+");
        System.out.print(words.length);
    }
}

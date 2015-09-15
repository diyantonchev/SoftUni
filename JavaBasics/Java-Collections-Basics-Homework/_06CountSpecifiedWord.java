import java.util.Scanner;

public class _06CountSpecifiedWord {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        String[] words = inputScanner.nextLine().split("\\W+");
        String specifiedWord = inputScanner.next();

        int count = 0;
        for (int i = 0; i < words.length; i++) {
            String currentWord = words[i];
            if (currentWord.equalsIgnoreCase(specifiedWord)){
                count++;
            }
        }

        System.out.print(count);
    }
}

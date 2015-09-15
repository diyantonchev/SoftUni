import java.util.Scanner;

public class _07CountSubstringOccurrences {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        String text = inputScanner.nextLine();
        String searchSubstring = inputScanner.nextLine();

        int count = 0;
        for (int i = 0; i < text.length(); i++) {
            if (i + searchSubstring.length() > text.length()){
                break;
            }
            String currentSubstring = text.substring(i, i + searchSubstring.length());
            if (currentSubstring.equalsIgnoreCase(searchSubstring)){
                count++;
            }
        }

        System.out.print(count);
    }
}

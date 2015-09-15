import java.util.Scanner;

public class _02SequencesOfEqualStrings {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        String[] strings = inputScanner.nextLine().split(" ");

        for (int i = 0; i < strings.length; i++) {
            String currentString = strings[i];
            if (!currentString.isEmpty()){
                System.out.print(currentString);
                if (strings.length > 1) {
                    for (int j = i + 1; j < strings.length; j++) {
                        String nextString = strings[j];
                        if (nextString.equals(currentString)) {
                            System.out.printf(" %s", nextString);
                            strings[j] = "";
                        }
                    }
                }
                System.out.println();
            }
        }
    }
}

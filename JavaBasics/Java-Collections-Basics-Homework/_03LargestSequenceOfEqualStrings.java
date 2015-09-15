import java.util.ArrayList;
import java.util.Scanner;

public class _03LargestSequenceOfEqualStrings {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);
        String[] strings = inputScanner.nextLine().split(" ");

        ArrayList<String> output = new ArrayList();
        for (int i = 0; i < strings.length; i++) {
            String currentString = strings[i];
            ArrayList equalStrings = new ArrayList();
            equalStrings.add(currentString);
            int index = i + 1;
            if (index < strings.length -1) {
                String nextString = strings[index];
                while (nextString.equals(currentString)) {
                    equalStrings.add(nextString);
                    index++;
                    if (index > strings.length - 1){
                        break;
                    }
                    nextString = strings[index];
                }
            }

            if (output.size() < equalStrings.size()) {
                output = new ArrayList<>(equalStrings);
            }
        }

        for (String string : output) {
            System.out.printf("%s ", string);
        }
    }
}

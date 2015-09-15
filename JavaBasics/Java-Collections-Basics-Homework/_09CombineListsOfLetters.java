import java.util.ArrayList;
import java.util.Scanner;

public class _09CombineListsOfLetters {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        char[] firstInputLetters = inputScanner.nextLine().replaceAll("\\s+", "").toCharArray();
        char[] secondInputLetters = inputScanner.nextLine().replaceAll("\\s+", "").toCharArray();

        ArrayList<Character> firstLetters = new ArrayList<>(convertToArray(firstInputLetters));
        ArrayList<Character> secondLetters = new ArrayList<>(convertToArray(secondInputLetters));

        ArrayList<Character> combinedLetters = new ArrayList<>(combineLists(firstLetters,secondLetters));

        for (Character letter : combinedLetters) {
            System.out.printf("%c ",letter);
        }
    }

    private static ArrayList<Character> convertToArray(char[] charArray) {
        ArrayList<Character> arrayList = new ArrayList<>();
        for (int i = 0; i < charArray.length; i++) {
            arrayList.add(charArray[i]);
        }

        return arrayList;
    }

    private static ArrayList<Character> combineLists(ArrayList<Character> firstList, ArrayList<Character> secondList) {
        ArrayList<Character> combinedList = new ArrayList<>();
        combinedList.addAll(firstList);
        for (int i = 0; i < secondList.size(); i++) {
            char currentLetter = secondList.get(i);
            boolean isAppear = firstList.contains(currentLetter);
            if (!isAppear){
                combinedList.add(currentLetter);
            }
        }

        return combinedList;
    }
}

package JavaBasics_11May_2015;

import java.util.ArrayList;
import java.util.Scanner;

public class _01Enigma {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);
        int n = Integer.parseInt(inputScanner.nextLine());

        ArrayList<String> messages = new ArrayList<>();
        for (int i = 0; i < n; i++) {
            messages.add(inputScanner.nextLine());
        }

        for (int i = 0; i < messages.size(); i++) {
            String decryptedMessage = decryptMessage(messages.get(i));
            messages.set(i, decryptedMessage);
        }

        messages.forEach(System.out::println);
    }

    private static String decryptMessage(String encryptedMessage) {
        StringBuilder decryptedMessage = new StringBuilder();
        int halfLength = getLength(encryptedMessage) / 2;
        for (int i = 0; i < encryptedMessage.length(); i++) {
            char currentChar = encryptedMessage.charAt(i);
            if (!isDigitOrWhiteSpace(currentChar)) {
                decryptedMessage.append(currentChar += (char) halfLength);
            } else {
                decryptedMessage.append(currentChar);
            }
        }
        return decryptedMessage.toString();
    }

    private static int getLength(String encryptedMessage) {
        int length = 0;
        for (int i = 0; i < encryptedMessage.length(); i++) {
            char currentChar = encryptedMessage.charAt(i);
            if (!isDigitOrWhiteSpace(currentChar)) {
                length++;
            }
        }
        return length;
    }

    private static boolean isDigitOrWhiteSpace(char character) {
        return Character.isDigit(character) || Character.isWhitespace(character);
    }
}

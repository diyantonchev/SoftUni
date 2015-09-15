import java.util.ArrayList;
import java.util.Arrays;
import java.util.Random;
import java.util.Scanner;

public class _06RandomHandsOf5Cards {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        ArrayList<Character> cardSuits = new ArrayList<>(Arrays.asList('♣', '♦', '♥', '♠'));
        ArrayList<String> cardFaces = new ArrayList<>(
                Arrays.asList("2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"));

        int numberOfHands = inputScanner.nextInt();
        Random random = new Random();
        final int cardsInHand = 5;

        for (int hand = 0; hand < numberOfHands; hand++) {
            for (int i = 0; i < cardsInHand; i++) {
                int faceIndex = random.nextInt(13);
                int suitsIndex = random.nextInt(4);
                System.out.printf("%s%s ", cardFaces.get(faceIndex), cardSuits.get(suitsIndex));
            }

            System.out.println();
        }
    }
}

package JavaBasics_22June_2014;

import java.util.*;

public class _04StraightFlush {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);
        String[] inputCards = inputScanner.nextLine().split("\\W+");
        HashSet<String> cards = new HashSet<String>() {{
            addAll(Arrays.asList(inputCards));
        }};

        int counter = 0;
        for (String card : cards) {
            String face = card.substring(0, card.length() - 1);
            String suit = card.substring(card.length() - 1);

            ArrayList<String> straightFlush = new ArrayList<>();
            for (int i = 0; i < 5; i++) {
                straightFlush.add(String.format("%s%s", face, suit));
                face = getNextFace(face);
            }

            if (cards.containsAll(straightFlush)) {
                System.out.println(straightFlush);
                counter++;
            }
        }
        if (counter == 0) {
            System.out.println("No Straight Flushes");
        }
    }

    private static String getNextFace(String cardFace) {
        String[] cardFaces = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        for (int i = 1; i < cardFaces.length; i++) {
            if (cardFaces[i - 1].equals(cardFace)) {
                return cardFaces[i];
            }
        }

        return null;
    }
}

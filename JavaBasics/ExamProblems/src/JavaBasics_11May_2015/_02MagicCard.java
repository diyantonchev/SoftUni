package JavaBasics_11May_2015;

import java.util.HashMap;
import java.util.Scanner;

public class _02MagicCard {

    public static void main(String[] args) {
        HashMap<String, Integer> cardValues = new HashMap<String, Integer>() {{
            put("2", 20);
            put("3", 30);
            put("4", 40);
            put("5", 50);
            put("6", 60);
            put("7", 70);
            put("8", 80);
            put("9", 90);
            put("10", 100);
            put("J", 120);
            put("Q", 130);
            put("K", 140);
            put("A", 150);
        }};

        Scanner inputScanner = new Scanner(System.in);

        String[] hand = inputScanner.nextLine().split("\\s+");
        String oddOrEven = inputScanner.nextLine();
        String magicCard = inputScanner.nextLine();

        int valueOfTheHand = 0;
        if (oddOrEven.equals("odd")) {
            valueOfTheHand = getOddPositionValues(hand, magicCard, cardValues);
        } else {
            valueOfTheHand = getEvenPositionValues(hand, magicCard, cardValues);
        }

        System.out.print(valueOfTheHand);
    }

    private static int getEvenPositionValues(String[] hand, String magicCard, HashMap<String, Integer> cardValues) {
        int valueOfTheHand = 0;
        for (int i = 0; i < hand.length; i += 2) {
            String card = hand[i];
            char cardFace = card.charAt(0);
            char cardSuit = card.charAt(1);
            if (cardFace == '1') {
                cardSuit = card.charAt(2);
            }
            char magicCardFace = magicCard.charAt(0);
            char magicCardSuit = magicCard.charAt(1);
            if (magicCardFace == '1') {
                magicCardSuit = magicCard.charAt(2);
            }
            if (cardSuit == magicCardSuit) {
                if (cardFace == '1') {
                    valueOfTheHand += cardValues.get("10") * 2;
                } else {
                    valueOfTheHand += cardValues.get(Character.toString(cardFace)) * 2;
                }
            } else if (cardFace == magicCardFace) {
                if (cardFace == '1') {
                    valueOfTheHand += cardValues.get("10") * 3;
                } else {
                    valueOfTheHand += cardValues.get(Character.toString(cardFace)) * 3;
                }
            } else {
                if (cardFace == '1') {
                    valueOfTheHand += cardValues.get("10");
                } else {
                    valueOfTheHand += cardValues.get(Character.toString(cardFace));
                }
            }
        }

        return valueOfTheHand;
    }

    private static int getOddPositionValues(String[] hand, String magicCard, HashMap<String, Integer> cardValues) {
        int valueOfTheHand = 0;
        for (int i = 1; i < hand.length; i += 2) {
            String card = hand[i];
            char cardFace = card.charAt(0);
            char cardSuit = card.charAt(1);
            if (cardFace == '1') {
                cardSuit = card.charAt(2);
            }
            char magicCardFace = magicCard.charAt(0);
            char magicCardSuit = magicCard.charAt(1);
            if (magicCardFace == '1') {
                magicCardSuit = magicCard.charAt(2);
            }

            if (cardSuit == magicCardSuit) {
                if (cardFace == '1') {
                    valueOfTheHand += cardValues.get("10") * 2;
                } else {
                    valueOfTheHand += cardValues.get(Character.toString(cardFace)) * 2;
                }
            } else if (cardFace == magicCardFace) {
                if (cardFace == '1') {
                    valueOfTheHand += cardValues.get("10") * 3;
                } else {
                    valueOfTheHand += cardValues.get(Character.toString(cardFace)) * 3;
                }
            } else {
                if (cardFace == '1') {
                    valueOfTheHand += cardValues.get("10");
                } else {
                    valueOfTheHand += cardValues.get(Character.toString(cardFace));
                }
            }
        }

        return valueOfTheHand;
    }
}

package ExamProblems;

import java.util.HashMap;
import java.util.Scanner;

public class _02SumCards {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);
        HashMap<String, Integer> cards = new HashMap<String, Integer>() {{
            put("2", 2);
            put("3", 3);
            put("4", 4);
            put("5", 5);
            put("6", 6);
            put("7", 7);
            put("8", 8);
            put("9", 9);
            put("10", 10);
            put("J", 12);
            put("Q", 13);
            put("K", 14);
            put("A", 15);
        }};

        String[] handOfCards = inputScanner.nextLine().split(" ");
        int valueOfTheHand = 0;
        for (int i = 0; i < handOfCards.length; i++) {
            String currentCardFace = handOfCards[i].substring(0, handOfCards[i].length() - 1);
            int count = 0;
            int bonusSum = 0;
            for (int j = i + 1; j < handOfCards.length; j++) {
                String nextCardFace = handOfCards[j].substring(0, handOfCards[i].length() - 1);
                if (nextCardFace.equals(currentCardFace)) {
                    bonusSum += cards.get(nextCardFace);
                    count++;
                } else {
                    break;
                }
            }
            int currentCardValue = cards.get(currentCardFace);
            if (bonusSum > 0) {
                valueOfTheHand += (bonusSum + currentCardValue) * 2;
            } else {
                valueOfTheHand += currentCardValue;
            }

            i += count;
        }

        System.out.print(valueOfTheHand);
    }
}

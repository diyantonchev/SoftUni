import java.util.ArrayList;
import java.util.Arrays;

public class _03FullHouse {
    public static void main(String[] args) {

        ArrayList<Character> cardSuits = new ArrayList<>(Arrays.asList('♣', '♦', '♥', '♠'));
        ArrayList<String> cardFaces = new ArrayList<>(
                Arrays.asList("2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"));

        int countOfFullHouses = 0;
        StringBuilder fullHouses = new StringBuilder();
        for (int firstFaceSuit1 = 0; firstFaceSuit1 < cardSuits.size(); firstFaceSuit1++) {
            for (int firstFaceSuit2 = firstFaceSuit1 + 1; firstFaceSuit2 < cardSuits.size(); firstFaceSuit2++) {
                for (int firstFaceSuit3 = firstFaceSuit2 + 1; firstFaceSuit3 < cardSuits.size(); firstFaceSuit3++) {
                    for (int secondFaceSuit1 = 0; secondFaceSuit1 < cardSuits.size(); secondFaceSuit1++) {
                        for (int secondFaceSuit2 = secondFaceSuit1 + 1; secondFaceSuit2 < cardSuits.size(); secondFaceSuit2++) {
                            for (int firstFace = 0; firstFace < cardFaces.size(); firstFace++) {
                                for (int secondFace = 0; secondFace < cardFaces.size(); secondFace++) {
                                    if (cardFaces.get(firstFace) != cardFaces.get(secondFace)){
                                        fullHouses.append(String.format(
                                                "(%1$s %2$s %1$s %3$s %1$s %4$s %5$s %6$s %5$s %7$s)\n\r",
                                                cardFaces.get(firstFace),
                                                cardSuits.get(firstFaceSuit1),
                                                cardSuits.get(firstFaceSuit2),
                                                cardSuits.get(firstFaceSuit3),
                                                cardFaces.get(secondFace),
                                                cardSuits.get(secondFaceSuit1),
                                                cardSuits.get(secondFaceSuit2)));

                                        countOfFullHouses++;
                                    }
                                }
                            }
                        }

                    }
                }
            }

        }

        System.out.println(fullHouses);
        System.out.printf("%d full houses", countOfFullHouses);
    }
}

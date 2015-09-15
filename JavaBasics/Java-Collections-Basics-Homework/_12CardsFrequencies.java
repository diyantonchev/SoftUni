import java.util.LinkedHashMap;
import java.util.Scanner;

public class _12CardsFrequencies {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        String[] cardFaces = inputScanner.nextLine().split("\\W+");
        LinkedHashMap<String, Integer> cardFrequency = new LinkedHashMap<>();
        fillMap(cardFrequency, cardFaces);
        for (String card : cardFrequency.keySet()) {
            int cardsCount = cardFaces.length;
            int currentCardAppearance = cardFrequency.get(card);
            double frequency = ((double) currentCardAppearance / cardsCount) * 100;
            System.out.printf("%s -> %.2f%%", card, frequency);
            System.out.println();
        }
    }

    private static void fillMap(LinkedHashMap<String, Integer> map, String[] keys) {
        for (int i = 0; i < keys.length; i++) {
            String currentKey = keys[i];
            if (!map.containsKey(currentKey)) {
                map.put(currentKey, 0);
            }
            int currentValue = map.get(currentKey);
            map.put(currentKey, currentValue + 1);
        }
    }
}

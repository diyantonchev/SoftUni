import java.util.Scanner;
import java.util.TreeMap;

public class _11MostFrequentWord {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        String[] words = inputScanner.nextLine().split("\\W+");

        TreeMap<String, Integer> aggregateWords = new TreeMap<>();
        fillMap(aggregateWords, words);

        int mostFrequentWordCount = getMostFrequentWordCount(aggregateWords);
        StringBuilder output = new StringBuilder();

        for (String word : aggregateWords.keySet()) {
            int currentWordCount = aggregateWords.get(word);
            boolean isMostFrequentWord = currentWordCount == mostFrequentWordCount;
            if (isMostFrequentWord) {
                output.append(String.format("%s -> %d times%n",word,currentWordCount));
            }
        }

        System.out.println(output.toString().trim());
    }

    private static void fillMap(TreeMap<String, Integer> map, String[] words) {
        for (int i = 0; i < words.length; i++) {
            String currentKey = words[i].toLowerCase();
            if (!map.containsKey(currentKey)) {
                map.put(currentKey, 0);
            }
            int currentValue = map.get(currentKey);
            map.put(currentKey, currentValue + 1);
        }
    }

    private static int getMostFrequentWordCount(TreeMap<String, Integer> words) {
        int mostFrequentCount = 0;
        for (String word : words.keySet()) {
            int currentWordCount = words.get(word);
            boolean isMostFrequent = currentWordCount > mostFrequentCount;
            if (isMostFrequent) {
                mostFrequentCount = currentWordCount;
            }
        }

        return mostFrequentCount;
    }
}

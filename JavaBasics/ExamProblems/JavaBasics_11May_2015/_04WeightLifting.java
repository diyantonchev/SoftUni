package JavaBasics_11May_2015;

import java.util.Scanner;
import java.util.TreeMap;

public class _04WeightLifting {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);
        int n = inputScanner.nextInt();
        inputScanner.nextLine();
        TreeMap<String, TreeMap<String, Long>> playersPerformance = new TreeMap<>();
        for (int i = 0; i < n; i++) {
            String[] exerciseInfo = inputScanner.nextLine().split("\\s+");
            String playerName = exerciseInfo[0];
            String exercise = exerciseInfo[1];
            long weight = Integer.parseInt(exerciseInfo[2]);

            if (!playersPerformance.containsKey(playerName)) {
                playersPerformance.put(playerName, new TreeMap<>());
            }
            if (!playersPerformance.get(playerName).containsKey(exercise)) {
                playersPerformance.get(playerName).put(exercise, weight);
            } else {
               long newValue = playersPerformance.get(playerName).get(exercise) + weight;
                playersPerformance.get(playerName).put(exercise, newValue);
            }
        }

        StringBuilder output = new StringBuilder();
        for (String player : playersPerformance.keySet()) {
            StringBuilder currentPlayerPerformance = new StringBuilder();
            currentPlayerPerformance.append(String.format("%s : ", player));
            for (String exercise : playersPerformance.get(player).keySet()) {
                currentPlayerPerformance.append(String.format(
                        "%s - %d kg, ", exercise, playersPerformance.get(player).get(exercise)));
            }
            output.append(String.format(
                    "%s%n", currentPlayerPerformance.toString().substring(0, currentPlayerPerformance.length() - 2)));
            currentPlayerPerformance.delete(0, currentPlayerPerformance.length());
        }

        System.out.print(output.toString().trim());
    }
}

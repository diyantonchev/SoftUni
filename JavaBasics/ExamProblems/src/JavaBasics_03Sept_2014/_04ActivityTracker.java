package JavaBasics_03Sept_2014;

import java.util.Scanner;
import java.util.TreeMap;

public class _04ActivityTracker {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        int n = Integer.parseInt(inputScanner.nextLine());
        TreeMap<Integer, TreeMap<String, Integer>> activityTracker = new TreeMap<>();
        for (int i = 0; i < n; i++) {
            String[] currentUserInfo = inputScanner.nextLine().split("\\s+");
            String[] date = currentUserInfo[0].split("/");
            int month = 0;
            if (date[1].charAt(0) == '0') {
                month = Integer.parseInt(date[1].substring(1, date[1].length()));
            } else {
                month = Integer.parseInt(date[1]);
            }
            String user = currentUserInfo[1];
            int distance = Integer.parseInt(currentUserInfo[2]);

            if (!activityTracker.containsKey(month)) {
                activityTracker.put(month, new TreeMap<>());
            }
            if (!activityTracker.get(month).containsKey(user)) {
                activityTracker.get(month).put(user, distance);
            } else {
                int newValue = activityTracker.get(month).get(user) + distance;
                activityTracker.get(month).put(user, newValue);
            }
        }

        StringBuilder output = new StringBuilder();
        for (Integer month : activityTracker.keySet()) {
            StringBuilder currentMonthInfo = new StringBuilder();
            currentMonthInfo.append(String.format("%d: ", month));
            for (String user : activityTracker.get(month).keySet()) {
                currentMonthInfo.append(
                        String.format("%s(%d), ", user, activityTracker.get(month).get(user)));
            }
            output.append(
                    String.format("%s%n", currentMonthInfo.toString().substring(0, currentMonthInfo.length() - 2)));
            currentMonthInfo.delete(0, currentMonthInfo.length());
        }

        System.out.print(output.toString().trim());
    }
}

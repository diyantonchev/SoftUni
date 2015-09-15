package ExamProblems;

import java.util.*;

public class _04LogsAggregator {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);
        int inputLines = inputScanner.nextInt();
        inputScanner.nextLine();

        TreeMap<String, HashMap<Integer, TreeSet<String>>> aggregateLogs = new TreeMap<>();
        for (int i = 0; i < inputLines; i++) {
            String[] currentLog = inputScanner.nextLine().split(" ");
            String ipAddress = currentLog[0];
            String user = currentLog[1];
            int duration = Integer.parseInt(currentLog[2]);

            if (!aggregateLogs.containsKey(user)) {
                TreeSet<String> ipSet = new TreeSet<String>() {{
                    add(ipAddress);
                }};
                HashMap<Integer, TreeSet<String>> usersIPAndDuration = new HashMap<Integer,TreeSet<String>>() {{
                    put(duration, ipSet);
                }};
                aggregateLogs.put(user, usersIPAndDuration);
            } else {
                int newKey = aggregateLogs.get(user).keySet().iterator().next();
                TreeSet newValue = aggregateLogs.get(user).get(newKey);
                newKey += duration;
                newValue.add(ipAddress);
                aggregateLogs.get(user).clear();
                aggregateLogs.get(user).put(newKey,newValue);
            }
        }

        StringBuilder output = new StringBuilder();
        for (String user : aggregateLogs.keySet()) {
            HashMap<Integer, TreeSet<String>> usersIPAndDuration = aggregateLogs.get(user);
            output.append(String.format("%s: ",user));
            for (Integer duration : usersIPAndDuration.keySet()) {
                output.append(String.format("%s %s%n",duration,usersIPAndDuration.get(duration).toString()));
            }
        }

        System.out.print(output.toString().trim());
    }
}

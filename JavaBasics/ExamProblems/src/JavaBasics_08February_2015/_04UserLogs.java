package JavaBasics_08February_2015;

import java.util.LinkedHashMap;
import java.util.Scanner;
import java.util.TreeMap;

public class _04UserLogs {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        TreeMap<String, LinkedHashMap<String, Integer>> userLogs = new TreeMap<>();
        String currentInputLine = inputScanner.nextLine();
        while (!currentInputLine.equals("end")) {
            String[] info = currentInputLine.split("\\s+");
            String ipAddress = info[0].substring(3,info[0].length());
            String userName = info[2].substring(5,info[2].length());
            if (!userLogs.containsKey(userName)) {
                LinkedHashMap<String, Integer> messageCountFromIP = new LinkedHashMap<String, Integer>() {{
                    put(ipAddress, 0);
                }};
                userLogs.put(userName, messageCountFromIP);
            }
            if (!userLogs.get(userName).containsKey(ipAddress)) {
                userLogs.get(userName).put(ipAddress, 1);
            } else {
                int currentValue = userLogs.get(userName).get(ipAddress);
                userLogs.get(userName).put(ipAddress, currentValue + 1);
            }

            currentInputLine = inputScanner.nextLine();
        }

        StringBuilder output = new StringBuilder();
        for (String userName : userLogs.keySet()) {
            output.append(String.format("%s: %n", userName));
            int currentKeyIndex = 0;
            for (String ip : userLogs.get(userName).keySet()) {
                if (currentKeyIndex < userLogs.get(userName).size() - 1) {
                    output.append(String.format("%s => %d, ", ip, userLogs.get(userName).get(ip)));
                } else {
                    output.append(String.format("%s => %d.%n", ip, userLogs.get(userName).get(ip)));
                }

                currentKeyIndex++;
            }
        }

        System.out.print(output.toString().trim());
    }
}
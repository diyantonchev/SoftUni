package JavaFundamentals_15November_2015;

import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _04LogParser {
    public static void main(String[] args) {

        Scanner inputScanner = new Scanner(System.in);
        final String regex = ".+?\\[\\\"(.+)\"\\].+?\\[\\\"(.+)\"\\].+?\\[\\\"(.+)\"\\]";
        TreeMap<String, LinkedHashMap<String, ArrayList<String>>> report = new TreeMap<>();

        String inputLine = inputScanner.nextLine();
        while (!inputLine.equals("END")) {

            Pattern pattern = Pattern.compile(regex);
            Matcher matcher = pattern.matcher(inputLine);
            if (matcher.find()) {

                String projectName = matcher.group(1);
                String errorType = matcher.group(2);
                String message = matcher.group(3);

                if (!report.containsKey(projectName)) {
                    report.put(projectName, new LinkedHashMap<>());
                }

                if (!report.get(projectName).containsKey(errorType)) {
                    report.get(projectName).put("Critical", new ArrayList<>());
                    report.get(projectName).put("Warning", new ArrayList<>());
                }

                report.get(projectName).get(errorType).add(message);

                inputLine = inputScanner.nextLine();
            }
        }

        report.entrySet()
                .stream()
                .sorted((p1, p2) -> {
                    int errorsCount1 = p1.getValue().get("Critical").size() + p1.getValue().get("Warning").size();
                    int errorsCount2 = p2.getValue().get("Critical").size() + p2.getValue().get("Warning").size();

                    if (errorsCount1 != errorsCount2) {
                        return Integer.compare(errorsCount2, errorsCount1);
                    }

                    return p1.getKey().compareTo(p2.getKey());
                }).forEach(pair -> {
            System.out.println(pair.getKey() + ":");
            ArrayList<String> critical = pair.getValue().get("Critical");
            ArrayList<String> warnings = pair.getValue().get("Warning");
            System.out.printf("Total Errors: %d%n", critical.size() + warnings.size());
            System.out.printf("Critical: %d%n", critical.size());
            System.out.printf("Warnings: %d%n", warnings.size());

            System.out.println("Critical Messages:");
            printList(critical);
            System.out.println("Warning Messages:");
            printList(warnings);
            System.out.println();
        });
    }

    private static void printList(ArrayList<String> list) {

        if (list.size() < 1) {
            System.out.println("--->None");
            return;
        }

        list.stream().sorted((e1, e2) -> {
            if (e1.length() != e2.length()) {
                return Integer.compare(e1.length(), e2.length());
            }

            return e1.compareTo(e2);
        }).forEach(error -> System.out.println("--->" + error));
    }
}

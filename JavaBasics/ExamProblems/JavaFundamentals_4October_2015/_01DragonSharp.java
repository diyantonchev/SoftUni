package JavaFundamentals_4October_2015;

import java.util.ArrayList;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _01DragonSharp {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        int numberOfLines = Integer.parseInt(inputScanner.nextLine());
        ArrayList<String> lines = new ArrayList<>();

        for (int i = 0; i < numberOfLines; i++) {
            lines.add(inputScanner.nextLine());
        }

        StringBuilder output = new StringBuilder();
        boolean hasAppend = false;
        for (int i = 0; i < lines.size(); i++) {
            String line = lines.get(i);
            char lastChar = line.charAt(line.length() - 1);
            Pattern stringPattern = Pattern.compile("\\\".+\\\"");
            Matcher stringMatcher = stringPattern.matcher(line);
            if (stringMatcher.find() && lastChar == ';') {
                String stringToPrint = stringMatcher.group();
                String[] lineAsArray = lines.get(i).split("\\s+");
                String statement = lineAsArray[0];
                if (statement.equals("if")) {
                    String condition = lineAsArray[1];
                    boolean conditionIsTrue = checkCondition(condition);
                    if (conditionIsTrue) {
                        hasAppend = true;
                        String command = lineAsArray[2];
                        switch (command) {
                            case "loop":
                                int count = Integer.parseInt(lineAsArray[3]);
                                output.append(append(stringToPrint, count));
                                break;
                            case "out":
                                output.append(append(stringToPrint, 1));
                                break;
                        }
                    } else {
                        hasAppend = false;
                    }
                } else if (!hasAppend) {
                    String command = lineAsArray[1];
                    switch (command) {
                        case "loop":
                            int count = Integer.parseInt(lineAsArray[2]);
                            output.append(append(stringToPrint, count));
                            break;
                        case "out":
                            output.append(append(stringToPrint, 1));
                            break;
                    }
                }
            } else {
                output = new StringBuilder(String.format("Compile time error @ line %d", i + 1));
                break;
            }
        }

        System.out.print(output);
    }

    private static boolean checkCondition(String condition) {
        Pattern operatorPattern = Pattern.compile("[<=>]+");
        Matcher operatorMatcher = operatorPattern.matcher(condition);
        String operator = new String();
        if (operatorMatcher.find()) {
            operator = operatorMatcher.group();
        }

        int firstNumber = 0;
        int secondNumber = 0;
        Pattern numberPattern = Pattern.compile("\\d+");
        Matcher numberMather = numberPattern.matcher(condition);
        boolean firstNumberHasChanged = false;
        while (numberMather.find()) {
            if (!firstNumberHasChanged) {
                firstNumber = Integer.parseInt(numberMather.group());
                firstNumberHasChanged = true;
            } else {
                secondNumber = Integer.parseInt(numberMather.group());
            }
        }

        switch (operator) {
            case ">":
                return firstNumber > secondNumber;
            case "<":
                return firstNumber < secondNumber;
            case "==":
                return firstNumber == secondNumber;
            default:
                return false;
        }
    }

    private static String append(String string, int count) {
        String stringToAppend = string.substring(1, string.length() - 1);
        StringBuilder output = new StringBuilder();
        for (int i = 0; i < count; i++) {
            output.append(String.format("%s%n", stringToAppend));
        }
        return output.toString();
    }
}

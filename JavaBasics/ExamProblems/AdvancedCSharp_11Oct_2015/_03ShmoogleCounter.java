package AdvancedCSharp_11Oct_2015;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _03ShmoogleCounter {
    public static void main(String[] args) {

        Scanner inputScanner = new Scanner(System.in);

        ArrayList<String> doubles = new ArrayList<>();
        ArrayList<String> ints = new ArrayList<>();

        String input = inputScanner.nextLine();
        while (!input.equals("//END_OF_CODE")) {

            Pattern variablePattern = Pattern.compile("(int|double)\\s([a-z][a-zA-z]*)");
            Matcher variableMatcher = variablePattern.matcher(input);

            while (variableMatcher.find()) {

                String variable = variableMatcher.group(1);
                String name = variableMatcher.group(2);

                if (variable.equals("double")) {
                    doubles.add(name);
                } else {
                    ints.add(name);
                }
            }

            input = inputScanner.nextLine();
        }

        Collections.sort(doubles);
        Collections.sort(ints);

        System.out.printf("Doubles: %s%nInts: %s",doubles.size() > 0 ? String.join(", ", doubles) : "None"
                ,ints.size() > 0 ? String.join(", ", ints) : "None");
    }
}

package ExamProblems;

import java.util.Scanner;

public class _01StuckNumbers {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);
        int n = inputScanner.nextInt();
        inputScanner.nextLine();
        String[] numbers = inputScanner.nextLine().split(" ");

        StringBuilder output = new StringBuilder();
        for (String a : numbers) {
            for (String b : numbers) {
                for (String c : numbers) {
                    for (String d : numbers) {
                        boolean aIsDistinct = isDistinct(a, b, c, d);
                        boolean bIsDistinct = isDistinct(b, a, c, d);
                        boolean cIsDistinct = isDistinct(c, a, b, d);
                        boolean dIsDistinct = isDistinct(d, a, b, c);
                        boolean numbersAreDistinct = aIsDistinct && bIsDistinct && cIsDistinct && dIsDistinct;
                        if (numbersAreDistinct) {
                            if ((a + b).equals(c + d)) {
                                output.append(String.format("%s|%s==%s|%s%n", a, b, c, d));
                            }
                        }
                    }
                }
            }
        }

        if (output.toString().isEmpty()){
            System.out.print("No");
        } else {
            System.out.print(output.toString().trim());
        }
    }

    private static boolean isDistinct(String a, String b, String c, String d) {
        boolean isDistinct = !a.equals(b) && !a.equals(c) && !a.equals(d);

        return isDistinct;
    }
}

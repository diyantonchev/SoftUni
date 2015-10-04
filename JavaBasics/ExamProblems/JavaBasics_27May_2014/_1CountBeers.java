package JavaBasics_27May_2014;

import java.util.Scanner;

public class _1CountBeers {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        int beersCount = 0;
        int stacksCount = 0;
        String input = inputScanner.nextLine();
        while (!input.equals("End")) {
            String[] info = input.split("\\s+");
            int count = Integer.parseInt(info[0]);
            String measure = info[1];

            if (measure.equals("stacks")) {
                stacksCount += count;
            } else {
                beersCount += count;
            }

            if (beersCount >= 20) {
                for (int i = beersCount; i >= 20; i -= 20) {
                    stacksCount += 1;
                    beersCount -= 20;
                }
            }

            input = inputScanner.nextLine();
        }

        System.out.printf("%d stacks + %d beers", stacksCount, beersCount);
    }
}

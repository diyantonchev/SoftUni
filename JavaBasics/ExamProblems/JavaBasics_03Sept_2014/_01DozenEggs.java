package JavaBasics_03Sept_2014;

import java.util.Scanner;

public class _01DozenEggs {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);
        final int weekDays = 7;
        int dozenCount = 0;
        int eggsCount = 0;
        for (int i = 0; i < weekDays; i++) {
            String[] amountOfEggs = inputScanner.nextLine().split("\\s+");
            int count = Integer.parseInt(amountOfEggs[0]);
            if (amountOfEggs[1].equals("eggs")) {
                eggsCount += count;
                if (eggsCount >= 12) {
                    int newDozens = eggsCount / 12;
                    dozenCount += newDozens;
                    eggsCount -= newDozens * 12;
                }
            } else if (amountOfEggs[1].equals("dozens")) {
                dozenCount += count;
            }
        }

        System.out.printf("%d dozens + %d eggs", dozenCount, eggsCount);
    }
}

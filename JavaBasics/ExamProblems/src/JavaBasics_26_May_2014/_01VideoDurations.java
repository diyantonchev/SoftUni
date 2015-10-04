package JavaBasics_26_May_2014;

import java.util.Scanner;

public class _01VideoDurations {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);
        String input = inputScanner.nextLine();
        int totalMinutes = 0;
        while (!input.equals("End")) {
            String[] time = input.split(":");
            int hours = Integer.parseInt(time[0]);
            int minutes = Integer.parseInt(time[1]);
            totalMinutes += minutes + hours * 60;
            input = inputScanner.nextLine();
        }

        int totalHours = totalMinutes / 60;
        totalMinutes = totalMinutes % 60;
        System.out.printf("%d:%02d", totalHours, totalMinutes);
    }
}
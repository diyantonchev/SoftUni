package JavaBasics_21Sept_2014Morning;

import java.util.Scanner;

public class _01Timespan {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);
        String[] startTime = getTime(inputScanner.nextLine());
        String[] endTime = getTime(inputScanner.nextLine());
        long startSeconds = makeTimeToSeconds(startTime);
        long endSeconds = makeTimeToSeconds(endTime);
        long difference = startSeconds - endSeconds;
        int seconds = (int) (difference % 60);
        int minutes = (int) (difference % 3600 / 60);
        int hours = (int) (difference / 3600);

        System.out.printf("%d:%s:%s",
                hours,
                minutes < 10 ? "0" + minutes : "" + minutes,
                seconds < 10 ? "0" + seconds : "" + seconds);
    }

    private static long makeTimeToSeconds(String[] time) {
        long seconds = Long.parseLong(time[2]) +
                Long.parseLong(time[1]) * 60 +
                Long.parseLong(time[0]) * 3600;
        return seconds;
    }

    private static String[] getTime(String inputTime) {
        String[] time = inputTime.split(":");
        return time;
    }
}

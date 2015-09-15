import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.time.temporal.ChronoUnit;
import java.util.Scanner;

public class _07DaysBetweenTwoDates {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        String firstInputDate = inputScanner.nextLine();
        String secondInputDate = inputScanner.nextLine();

        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("['d']d-MM-yyy");
        LocalDate firstDate = LocalDate.parse(firstInputDate, formatter);
        LocalDate secondDate = LocalDate.parse(secondInputDate, formatter);

        long differenceBetweenTwoDates = ChronoUnit.DAYS.between(firstDate, secondDate);
        System.out.println(differenceBetweenTwoDates);
    }
}

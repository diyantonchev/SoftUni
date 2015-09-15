import java.util.Scanner;

public class _06FormattingNumbers {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        int a = inputScanner.nextInt();
        double b = inputScanner.nextDouble();
        double c = inputScanner.nextDouble();

        int aToBinary = Integer.parseInt(Integer.toBinaryString(a));

        System.out.printf("|%-10X|%010d|%10.2f|%-10.3f|",a, aToBinary, b, c);
    }
}

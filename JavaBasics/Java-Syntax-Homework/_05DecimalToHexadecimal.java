import java.util.Scanner;

public class _05DecimalToHexadecimal {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        int decimal = inputScanner.nextInt();
        String hexadecimal = Integer.toHexString(decimal);

        System.out.println(hexadecimal);
    }
}

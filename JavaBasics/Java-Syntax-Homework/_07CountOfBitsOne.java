import java.util.Scanner;

public class _07CountOfBitsOne {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        int n = inputScanner.nextInt();
        int countOFBitsOne = Integer.bitCount(n);

        System.out.println(countOFBitsOne);
    }
}

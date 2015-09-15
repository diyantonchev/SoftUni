import java.util.Scanner;

public class _08CountOfEqualBitPairs {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        int number = inputScanner.nextInt();
        String numberToBinary = Integer.toBinaryString(number);

        int bitPairsCount = 0;
        for (int i = 1; i < numberToBinary.length(); i++) {
            if (numberToBinary.charAt(i - 1)== numberToBinary.charAt(i)){
                bitPairsCount++;
            }
        }

        System.out.println(bitPairsCount);
    }
}
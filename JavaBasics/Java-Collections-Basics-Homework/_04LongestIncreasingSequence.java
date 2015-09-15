import java.util.ArrayList;
import java.util.Scanner;

public class _04LongestIncreasingSequence {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);
        String[] inputNumbers = inputScanner.nextLine().split(" ");
        int[] numbers = parseNumbers(inputNumbers);

        ArrayList<ArrayList<Integer>> sequences = new ArrayList<>();
        int currentIndex = 0;
        while (currentIndex < numbers.length) {
            ArrayList<Integer> currentSequence = new ArrayList();
            currentSequence.add(numbers[currentIndex]);
            int count = 0;
            for (int i = currentIndex + 1; i < numbers.length; i++) {
                int previousNumber = numbers[i - 1];
                int nextNumber = numbers[i];
                if (nextNumber > previousNumber) {
                    currentSequence.add(nextNumber);
                    count++;
                } else {
                    break;
                }
            }
            currentIndex += count + 1;
            sequences.add(currentSequence);
        }

        int indexOfLongest = 0;
        for (ArrayList<Integer> sequence : sequences) {
            Print(sequence);
            System.out.println();
            boolean isLongest = sequence.size() > sequences.get(indexOfLongest).size();
            if (isLongest) {
                indexOfLongest = sequences.indexOf(sequence);
            }
        }

        System.out.print("Longest: ");
        Print(sequences.get(indexOfLongest));
    }

    private static void Print(ArrayList<Integer> sequence) {
        for (Integer number : sequence) {
            System.out.printf("%d ",number);
        }
    }

    private static int[] parseNumbers(String[] inputNumbers) {
        int[] numbers = new int[inputNumbers.length];
        for (int i = 0; i < inputNumbers.length; i++) {
            numbers[i] = Integer.parseInt(inputNumbers[i]);
        }

        return numbers;
    }
}

package JavaBasics_21Sept_2014Evening;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class _01MirrorNumbers {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);
        inputScanner.nextLine();


        String[] numbers = inputScanner.nextLine().split("\\s+");
        ArrayList<String> numbersAsList = new ArrayList<String>() {{
            addAll(Arrays.asList(numbers));
        }};
        StringBuilder output = new StringBuilder();
        for (int i = 0; i < numbers.length; i++) {
            String number = numbers[i];
            List mirrorNumbers = numbersAsList.stream()
                    .filter(n -> !n.equals(number))
                    .filter(n -> new StringBuffer(n).reverse().toString().equals(number))
                    .collect(Collectors.toList());
            if (mirrorNumbers.size() > 0) {
                String mirrorNumber = mirrorNumbers.get(0).toString();
                output.append(String.format("%s<!>%s%n",number,mirrorNumber));
            }
            numbersAsList.remove(number);
        }

        if (!output.toString().isEmpty()){
            System.out.print(output.toString().trim());
        } else {
            System.out.print("No");
        }
    }
}

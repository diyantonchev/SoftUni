package ExamProblems;

import java.math.BigDecimal;
import java.util.Scanner;

public class _03SimpleExpression {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);
        String expression = inputScanner.nextLine();
        expression = expression.replace(" ", "");
        String[] numbers = expression.trim().split("[^0-9.]+");
        String[] operators = expression.split("[0-9.]+");

        BigDecimal sum = new BigDecimal(numbers[0]);
        for (int i = 1; i < operators.length; i += 1) {
            BigDecimal currentNumber = new BigDecimal(numbers[i]);
            String operator = operators[i];
            switch (operator) {
                case "+":
                   sum = sum.add(currentNumber);
                    break;
                case "-":
                   sum = sum.subtract(currentNumber);
                    break;
                default:
                    break;
            }
        }

        System.out.printf(sum.toPlainString());
    }
}
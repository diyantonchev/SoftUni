package AdvancedCSharp_11Oct_2015;

import java.util.*;

public class _01ArrayManipulator {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        ArrayList<String> numbers = new ArrayList<>(Arrays.asList(inputScanner.nextLine().split("\\s+")));
        String input = inputScanner.nextLine();
        while (!input.equals("end")) {

            String[] commands = input.split("\\s+");
            String command = commands[0];
            switch (command) {
                case "exchange":
                    int index = Integer.parseInt(commands[1]);
                    numbers = executeExchangeCommand(numbers, index);
                    break;
                case "max":
                    String maxOddOrEven = commands[1];
                    executeMaxCommand(numbers, maxOddOrEven);
                    break;
                case "min":
                    String minOddOrEven = commands[1];
                    executeMinCommand(numbers, minOddOrEven);
                    break;
                case "first":
                    int firstCount = Integer.parseInt(commands[1]);
                    String firstOddOrEven = commands[2];
                    executeFirstCommand(numbers, firstCount, firstOddOrEven);
                    break;
                case "last":
                    int lastCount = Integer.parseInt(commands[1]);
                    String lastOddOrEven = commands[2];
                    executeLastCommand(numbers, lastCount, lastOddOrEven);
                    break;
            }

            input = inputScanner.nextLine();
        }

        System.out.printf("[%s]", String.join(", ", numbers));
    }

    private static void executeLastCommand(ArrayList<String> numbers, int lastCount, String lastOddOrEven) {
        if (lastCount > numbers.size()) {
            System.out.println("Invalid count");
        } else {
            ArrayList<String> lastElements = new ArrayList<>();
            if (lastOddOrEven.equals("even")) {
                for (int i = numbers.size() - 1; i >= 0 ; i--) {
                    int currentNumber = Integer.parseInt(numbers.get(i));
                    if (currentNumber % 2 == 0){
                        lastElements.add(numbers.get(i));
                    }

                    if (lastElements.size() == lastCount){
                        break;
                    }
                }

            } else {
                for (int i = numbers.size() - 1; i >= 0 ; i--) {
                    int currentNumber = Integer.parseInt(numbers.get(i));
                    if (currentNumber % 2 != 0){
                        lastElements.add(numbers.get(i));
                    }

                    if (lastElements.size() == lastCount){
                        break;
                    }
                }
            }

            Collections.reverse(lastElements);
            System.out.printf("[%s]%n", lastElements.size() > 0 ?
                    String.join(", ", lastElements) : "");
        }
    }

    private static void executeFirstCommand(ArrayList<String> numbers, int firstCount, String firstOddOrEven) {
        if (firstCount > numbers.size()) {
            System.out.println("Invalid count");
        } else {
            ArrayList<String> firstElements = new ArrayList<>();
            if (firstOddOrEven.equals("even")) {
                for (String number : numbers) {
                    int currentNumber = Integer.parseInt(number);
                    if (currentNumber % 2 == 0) {
                        firstElements.add(number);
                    }

                    if (firstElements.size() == firstCount) {
                        break;
                    }
                }
            } else {
                for (String number : numbers) {
                    int currentNumber = Integer.parseInt(number);
                    if (currentNumber % 2 != 0) {
                        firstElements.add(number);
                    }

                    if (firstElements.size() == firstCount) {
                        break;
                    }
                }
            }

            System.out.printf("[%s]%n", firstElements.size() > 0 ?
                    String.join(", ", firstElements) : "");
        }
    }

    private static void executeMinCommand(ArrayList<String> numbers, String minOddOrEven) {
        int indexOfMinNumber = -1;
        int minNumber = Integer.MAX_VALUE;
        if (minOddOrEven.equals("even")) {
            for (int i = 0; i < numbers.size(); i++) {
                int currentNumber = Integer.parseInt(numbers.get(i));
                if (currentNumber % 2 == 0) {
                    if (currentNumber <= minNumber) {
                        minNumber = currentNumber;
                        indexOfMinNumber = i;
                    }
                }
            }
        } else {
            for (int i = 0; i < numbers.size(); i++) {
                int currentNumber = Integer.parseInt(numbers.get(i));
                if (currentNumber % 2 != 0) {
                    if (currentNumber <= minNumber) {
                        minNumber = currentNumber;
                        indexOfMinNumber = i;
                    }
                }
            }
        }

        if (indexOfMinNumber == -1) {
            System.out.println("No matches");
        } else {
            System.out.println(indexOfMinNumber);
        }
    }

    private static void executeMaxCommand(ArrayList<String> numbers, String oddOrEven) {
        int indexOfMaxNumber = -1;
        int maxNumber = Integer.MIN_VALUE;
        if (oddOrEven.equals("even")) {
            for (int i = 0; i < numbers.size(); i++) {
                int currentNumber = Integer.parseInt(numbers.get(i));
                if (currentNumber % 2 == 0) {
                    if (currentNumber >= maxNumber) {
                        maxNumber = currentNumber;
                        indexOfMaxNumber = i;
                    }
                }
            }
        } else {
            for (int i = 0; i < numbers.size(); i++) {
                int currentNumber = Integer.parseInt(numbers.get(i));
                if (currentNumber % 2 != 0) {
                    if (currentNumber >= maxNumber) {
                        maxNumber = currentNumber;
                        indexOfMaxNumber = i;
                    }
                }
            }
        }

        if (indexOfMaxNumber == -1) {
            System.out.println("No matches");
        } else {
            System.out.println(indexOfMaxNumber);
        }
    }

    private static ArrayList<String> executeExchangeCommand(ArrayList<String> numbers, int index) {
        ArrayList<String> exchangedList = new ArrayList<>();
        if (index > numbers.size() - 1 || index < 0) {
            System.out.println("Invalid index");
        } else {

            for (int i = 0; i < numbers.size(); i++) {
                String number = numbers.get((index + 1 + i) % numbers.size());
                exchangedList.add(number);
            }
            return exchangedList;
        }

        return numbers;
    }
}
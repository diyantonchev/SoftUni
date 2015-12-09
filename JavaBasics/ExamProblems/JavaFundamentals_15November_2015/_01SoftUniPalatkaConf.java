package JavaFundamentals_15November_2015;

import java.util.Scanner;

public class _01SoftUniPalatkaConf {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        int peopleCount = Integer.parseInt(inputScanner.nextLine());
        int inputRows = Integer.parseInt(inputScanner.nextLine());
        int bedsCount = 0;
        int mealsCount = 0;
        for (int i = 0; i < inputRows; i++) {
            String currentLine = inputScanner.nextLine();
            String[] tokens = currentLine.split("\\s+");
            if (tokens[0].compareTo("tents") == 0) {
                if (tokens[2].compareTo("normal") == 0) {
                    bedsCount += Integer.parseInt(tokens[1]) * 2;
                } else {
                    bedsCount += Integer.parseInt(tokens[1]) * 3;
                }
            } else if (tokens[0].compareTo("rooms") == 0) {
                if (tokens[2].compareTo("single") == 0) {
                    bedsCount += Integer.parseInt(tokens[1]) * 1;
                } else if (tokens[2].compareTo("double") == 0) {
                    bedsCount += Integer.parseInt(tokens[1]) * 2;
                } else {
                    bedsCount += Integer.parseInt(tokens[1]) * 3;
                }
            } else {
                if (tokens[2].compareTo("musaka") == 0) {
                    mealsCount += Integer.parseInt(tokens[1]) * 2;
                }
            }
        }

        int bedsDiff = Math.abs(bedsCount - peopleCount);
        if (bedsCount >= peopleCount) {
            System.out.printf("Everyone is happy and sleeping well. Beds left: %d%n", bedsDiff);
        } else {
            System.out.printf("Some people are freezing cold. Beds needed: %d%n", bedsDiff);
        }

        int mealsDiff = Math.abs(mealsCount - peopleCount);
        if (mealsCount >= peopleCount){
            System.out.printf("Nobody left hungry. Meals left: %d", mealsDiff);
        } else {
            System.out.printf("People are starving. Meals needed: %d", mealsDiff);
        }
    }
}

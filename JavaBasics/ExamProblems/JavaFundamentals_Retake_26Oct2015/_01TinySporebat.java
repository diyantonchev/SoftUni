package JavaFundamentals_Retake_26Oct2015;

import java.util.Scanner;

public class _01TinySporebat {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        final char specialCharacter = 'L';
        final int healthBonus = 200;
        final int sporebatCost = 30;

        int health = 5800;
        int glowcap = 0;
        String inputLine = inputScanner.nextLine();
        while (!inputLine.equals("Sporeggar")) {

            for (int i = 0; i < inputLine.length(); i++) {
                if (health <= 0) {
                    break;
                }
                char currentChar = inputLine.charAt(i);
                if (i < inputLine.length() - 1) {
                    if (currentChar == specialCharacter) {
                        health += healthBonus;
                    } else {
                        int damage = currentChar;
                        health -= damage;
                    }

                } else {
                    glowcap += Integer.parseInt(Character.toString(currentChar));
                }
            }

            if (health <= 0) {
                break;
            }

            inputLine = inputScanner.nextLine();
        }

        if (health > 0) {
            System.out.printf("Health left: %d%n", health);
            if (glowcap >= sporebatCost) {
                glowcap -= sporebatCost;
                System.out.printf("Bought the sporebat. Glowcaps left: %d%n", glowcap);
            } else {
                int diff = sporebatCost - glowcap;
                System.out.printf("Safe in Sporeggar, but another %d Glowcaps needed.", diff);
            }
        } else {
            System.out.printf("Died. Glowcaps: %d", glowcap);
        }
    }
}

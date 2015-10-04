package JavaBasics_11May_2015;

import java.util.HashMap;
import java.util.Scanner;

public class _03LabyrinthDash {
    public static void main(String[] args) {

        Scanner inputScanner = new Scanner(System.in);
        int rows = Integer.parseInt(inputScanner.nextLine());
        char[][] labyrinth = new char[rows][];
        for (int i = 0; i < rows; i++) {
            labyrinth[i] = inputScanner.nextLine().toCharArray();
        }

        String commands = inputScanner.nextLine();
        int lives = 3;
        int moves = 0;
        int row = 0;
        int cell = 0;
        for (int i = 0; i < commands.length(); i++) {
            int initialRow = row;
            int initialCell = cell;
            char currentCommand = commands.charAt(i);
            switch (currentCommand) {
                case '^':
                    row -= 1;
                    break;
                case 'v':
                    row += 1;
                    break;
                case '>':
                    cell += 1;
                    break;
                case '<':
                    cell -= 1;
                    break;
            }
            if (row > labyrinth.length - 1 || row < 0) {
                moves++;
                System.out.println("Fell off a cliff! Game Over!");
                break;
            }
            if (cell > labyrinth[row].length - 1 || cell < 0) {
                moves++;
                System.out.println("Fell off a cliff! Game Over!");
                break;
            }
            char currentSymbol = labyrinth[row][cell];
            if (currentSymbol == ' ') {
                moves++;
                System.out.println("Fell off a cliff! Game Over!");
                break;
            }
            switch (currentSymbol) {
                case '@':
                    lives -= 1;
                    break;
                case '#':
                    lives -= 1;
                    break;
                case '*':
                    lives -= 1;
                    break;
                case '$':
                    lives += 1;
                    labyrinth[row][cell] = '.';
                    break;
                default:
                    break;
            }
            String lifeLostMessage = String.format("Ouch! That hurt! Lives left: %s", lives);
            String lifeGainedMessage = String.format("Awesome! Lives left: %s", lives);
            HashMap<Character, String> specialSymbols = new HashMap<Character, String>() {{
                put('_', "Bumped a wall.");
                put('|', "Bumped a wall.");
                put('@', lifeLostMessage);
                put('#', lifeLostMessage);
                put('*', lifeLostMessage);
                put('$', lifeGainedMessage);
                put('.', "Made a move!");
            }};
            if (currentSymbol != '|' && currentSymbol != '_') {
                moves++;
            } else {
                row = initialRow;
                cell = initialCell;
            }
            if (lives <= 0) {
                System.out.println(lifeLostMessage);
                System.out.println("No lives left! Game Over!");
                break;
            }

            System.out.println(specialSymbols.get(currentSymbol));
        }

        System.out.printf("Total moves made: %s", moves);
    }
}
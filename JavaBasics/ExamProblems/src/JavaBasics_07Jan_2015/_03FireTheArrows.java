package JavaBasics_07Jan_2015;

import java.util.ArrayList;
import java.util.Scanner;

public class _03FireTheArrows {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);
        ArrayList<Character> characters = new ArrayList<Character>() {{
            add('<');
            add('>');
            add('^');
            add('v');
        }};
        int n = Integer.parseInt(inputScanner.nextLine());
        char[][] matrix = new char[n][];
        for (int row = 0; row < n; row++) {
            String currentRow = inputScanner.nextLine();
            matrix[row] = new char[currentRow.length()];
            matrix[row] = currentRow.toCharArray();
        }

        boolean canMove = true;
        while (canMove) {
            canMove = false;
            for (int row = 0; row < matrix.length; row++) {
                for (int col = 0; col < matrix[row].length; col++) {
                    char currentChar = matrix[row][col];
                    switch (currentChar) {
                        case '<':
                            boolean canMoveLeft = col - 1 >= 0 && !characters.contains(matrix[row][col - 1]);
                            if (canMoveLeft) {
                                matrix[row][col - 1] = '<';
                                matrix[row][col] = 'o';
                                canMove = true;
                            }
                            break;
                        case '>':
                            boolean canMoveRight = col + 1 <= matrix[row].length - 1 && !characters.contains(matrix[row][col + 1]);
                            if (canMoveRight) {
                                matrix[row][col + 1] = '>';
                                matrix[row][col] = 'o';
                                canMove = true;
                            }
                            break;
                        case '^':
                            boolean canMoveUp = row - 1 >= 0 && !characters.contains(matrix[row - 1][col]);
                            if (canMoveUp) {
                                matrix[row - 1][col] = '^';
                                matrix[row][col] = 'o';
                                canMove = true;
                            }
                            break;
                        case 'v':
                            boolean canMoveDown = row + 1 <= matrix.length - 1 && !characters.contains(matrix[row + 1][col]);
                            if (canMoveDown) {
                                matrix[row + 1][col] = 'v';
                                matrix[row][col] = 'o';
                                canMove = true;
                            }
                            break;
                    }
                }
            }
        }

        printMatrix(matrix);
    }

    private static void printMatrix(char[][] matrix) {
        for (int row = 0; row < matrix.length; row++) {
            for (int col = 0; col < matrix[row].length; col++) {
                System.out.print(matrix[row][col]);
            }

            System.out.println();
        }
    }
}
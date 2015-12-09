package JavaFundamentals_Retake_26Oct2015;

import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.Scanner;

public class _03TheHeiganDance {

    static double playerHitPoints = 18500;
    static int playerStartRow = 15 / 2;
    static int playerStartCol = 15 / 2;

    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        HashMap<String, Integer> cloud = new HashMap<String, Integer>() {{
            put("Cloud", 3500);
        }};

        HashMap<String, Integer> eruption = new HashMap<String, Integer>() {{
            put("Eruption", 6000);
        }};

        char[][] matrix = new char[15][15];

        matrix[playerStartRow][playerStartCol] = 'P';
        double heiganHitPoints = 3000000;
        double payerDamage = Double.parseDouble(inputScanner.nextLine());
        String result = new String();
        boolean cloudHitAgain = true;
        while (true) {
            if (playerHitPoints <= 0 || heiganHitPoints <= 0) {
                break;
            }

            String[] input = inputScanner.nextLine().split("\\s+");
            String spell = input[0];
            int row = Integer.parseInt(input[1]);
            int col = Integer.parseInt(input[2]);

            if (isInsideMatrix(row, col, matrix) && heiganHitPoints > 0) {

                Cell cell = new Cell(row - 1, col - 1);
                Cell cell1 = new Cell(row - 1, col);
                Cell cell2 = new Cell(row - 1, col + 1);
                Cell cell3 = new Cell(row, col - 1);
                Cell cell4 = new Cell(row, col);
                Cell cell5 = new Cell(row, col + 1);
                Cell cell6 = new Cell(row + 1, col - 1);
                Cell cell7 = new Cell(row + 1, col);
                Cell cell8 = new Cell(row + 1, col + 1);
                ArrayList<Cell> cells = new ArrayList<Cell>() {{
                    Arrays.asList(cell, cell1, cell2, cell3, cell4, cell5, cell6, cell7, cell8);
                }};

                boolean isHitPlayer = isHitPlayerCheck(cells, matrix);
                if (!cloudHitAgain) {
                    playerHitPoints -= 3500;
                    cloudHitAgain = true;
                }

                if (isHitPlayer) {
                    if (cloud.containsKey(spell)) {
                        playerHitPoints -= cloud.get(spell);
                        cloudHitAgain = false;

                        if (playerHitPoints <= 0) {
                            result = "Player: Killed by Plague Cloud";
                        }
                    } else {
                        playerHitPoints -= eruption.get(spell);

                        if (playerHitPoints <= 0) {
                            result = "Player: Killed by Eruption";
                        }
                    }
                }

            }

            heiganHitPoints -= payerDamage;
        }

        if (heiganHitPoints <= 0) {
            System.out.println("Heigan: Defeated!");
        } else {
            System.out.printf("Heigan: %.2f%n", heiganHitPoints);
        }

        if (result.isEmpty()) {
            System.out.printf("Player: %.0f%n", playerHitPoints);
        } else {
            System.out.println(result);
        }
        Cell finalCell = getFinalCell(matrix);
        System.out.printf("Final position: %d, %d", finalCell.getRow(), finalCell.getCol());
    }

    private static Cell getFinalCell(char[][] matrix) {
        for (int row = 0; row < matrix.length; row++) {
            for (int col = 0; col < matrix[row].length; col++) {
                if (matrix[row][col] == 'P') {
                    return new Cell(row, col);
                }
            }
        }

        return new Cell(0, 0);
    }

    private static boolean playerMove(ArrayList<Cell> cells, char[][] matrix, int startRow, int startCol) {
        Cell upMove = new Cell(startRow - 1, startCol);
        Cell rightMove = new Cell(startRow, startCol + 1);
        Cell downMove = new Cell(startRow - 1, startCol);
        Cell leftMove = new Cell(startRow, startCol - 1);

        if (!cells.stream()
                .anyMatch(c -> c.getRow() == upMove.getRow()
                        && c.getCol() == upMove.getCol())) {
            int row = upMove.getRow();
            int col = upMove.getCol();
            if (isInsideMatrix(row, col, matrix)) {
                matrix[row][col] = 'P';
                matrix[playerStartRow][playerStartCol] = '.';
            }

            return true;
        } else if (!cells.stream()
                .anyMatch(cell -> cell.getRow() == rightMove.getRow()
                        && cell.getCol() == rightMove.getCol())) {

            int row = rightMove.getRow();
            int col = rightMove.getCol();
            if (isInsideMatrix(row, col, matrix)) {
                matrix[rightMove.getRow()][rightMove.getCol()] = 'P';
                matrix[startRow][startCol] = '.';
                return true;
            }
        } else if (!cells.stream().anyMatch(cell -> cell.getRow() == downMove.getCol()
                && cell.getCol() == downMove.getCol())) {
            int row = downMove.getRow();
            int col = downMove.getCol();
            if (isInsideMatrix(row, col, matrix)) {
                matrix[downMove.getRow()][downMove.getCol()] = 'P';
                matrix[startRow][startCol] = '.';
                return true;
            }
        } else if (!cells.stream()
                .anyMatch(cell -> cell.getRow() == leftMove.getRow()
                        && cell.getCol() == leftMove.getCol())) {
            int row = leftMove.getRow();
            int col = leftMove.getCol();
            if (isInsideMatrix(row, col, matrix)) {
                matrix[leftMove.getRow()][leftMove.getCol()] = 'P';
                matrix[startRow][startCol] = '.';
                return true;
            }
        }
        return false;
    }

    private static boolean isHitPlayerCheck(ArrayList<Cell> cells, char[][] matrix) {
        for (Cell c : cells) {
            if (isInsideMatrix(c.getRow(), c.getCol(), matrix)) {
                if (matrix[c.getRow()][c.getCol()] == 'P') {
                    boolean playerCanMove = playerMove(cells, matrix, c.getRow(), c.getCol());
                    if (!playerCanMove) {
                        return true;
                    }
                }
            }
        }

        return false;
    }


    private static boolean isInsideMatrix(int row, int col, char[][] matrix) {

        return row >= 0 && row < matrix.length && col >= 0 && col < matrix[row].length;
    }
}


class Cell {
    int row;
    int column;

    public Cell(int row, int column) {
        this.row = row;
        this.column = column;
    }

    public int getRow() {
        return this.row;
    }

    public int getCol() {
        return this.column;
    }
}
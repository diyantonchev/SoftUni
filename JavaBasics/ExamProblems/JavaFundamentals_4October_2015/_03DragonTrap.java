package JavaFundamentals_4October_2015;

import java.util.ArrayList;
import java.util.Scanner;

public class _03DragonTrap {

    private static ArrayList<Cell> cellsToRotate = new ArrayList<Cell>();

    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        ArrayList<char[]> originalMatrix = new ArrayList<>();
        ArrayList<char[]> matrix = new ArrayList<>();
        int numberOfRows = Integer.parseInt(inputScanner.nextLine());
        readMatrix(numberOfRows, originalMatrix, matrix, inputScanner);
        String commandLine = inputScanner.nextLine();
        while (!commandLine.equals("End")) {
            String[] info = commandLine.split("[()\\s]+");
            int x = Integer.parseInt(info[1]);
            int y = Integer.parseInt(info[2]);
            int radius = Integer.parseInt(info[3]);
            int rotations = Integer.parseInt(info[4]);

            ArrayList<Character> symbolsToRotate = new ArrayList();
            symbolsToRotate = getSymbolsToRotate(matrix, x, y, radius);

            if (symbolsToRotate.size() > 0) {
                rotations %= symbolsToRotate.size();
            }

            if (rotations != 0) {
                int index = rotations < 0 ? -rotations : symbolsToRotate.size() - rotations;

                for (Cell cell : cellsToRotate) {
                    matrix.get(cell.getRow())[cell.getCol()] = symbolsToRotate.get(index);
                    index = (index + 1) % symbolsToRotate.size();
                }
            }

            cellsToRotate.clear();
            commandLine = inputScanner.nextLine();
        }

        printOutput(matrix, originalMatrix);
    }

    private static void printOutput(ArrayList<char[]> matrix, ArrayList<char[]> originalMatrix) {
        int symbolsChanged = 0;
        for (int row = 0; row < matrix.size(); row++) {
            for (int col = 0; col < matrix.get(row).length; col++) {
                if (matrix.get(row)[col] != originalMatrix.get(row)[col]){
                    symbolsChanged++;
                }

                System.out.print(matrix.get(row)[col]);
            }
            System.out.println();
        }

        System.out.printf("Symbols changed: %d",symbolsChanged);
    }

    private static ArrayList<Character> getSymbolsToRotate(ArrayList<char[]> matrix, int x, int y, int radius) {
        int starRow = x - radius;
        int startCol = y - radius;
        int endRow = x + radius;
        int endCol = y + radius;

        int row;
        int col;

        ArrayList<Character> symbols = new ArrayList<>();

        for (col = startCol, row = starRow; col <= endCol; col++) {
            if (isInsideMatrix(row, col, matrix)) {
                char currentChar = matrix.get(row)[col];
                symbols.add(currentChar);
                cellsToRotate.add(new Cell(row, col));
            }
        }

        for (row = starRow + 1, col = endCol; row <= endRow; row++) {
            if (isInsideMatrix(row, col, matrix)) {
                char currentChar = matrix.get(row)[col];
                symbols.add(currentChar);
                cellsToRotate.add(new Cell(row, col));
            }
        }

        for (col = endCol - 1, row = endRow; col >= startCol; col--) {
            if (isInsideMatrix(row, col, matrix)) {
                char currentChar = matrix.get(row)[col];
                symbols.add(currentChar);
                cellsToRotate.add(new Cell(row, col));
            }
        }

        for (row = endRow - 1, col = startCol; row > starRow; row--) {
            if (isInsideMatrix(row, col, matrix)) {
                char currentChar = matrix.get(row)[col];
                symbols.add(currentChar);
                cellsToRotate.add(new Cell(row, col));
            }
        }

        return symbols;
    }

    private static boolean isInsideMatrix(int row, int col, ArrayList<char[]> matrix) {

        return row >= 0 && row < matrix.size() && col >= 0 && col < matrix.get(row).length;
    }

    private static void readMatrix(int numberOfRows, ArrayList<char[]> originalMatrix, ArrayList<char[]> matrix, Scanner inputScanner) {
        for (int i = 0; i < numberOfRows; i++) {
            String input = inputScanner.nextLine();
            matrix.add(input.toCharArray());
            originalMatrix.add(input.toCharArray());
        }
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
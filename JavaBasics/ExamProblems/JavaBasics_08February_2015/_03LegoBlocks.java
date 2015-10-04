package JavaBasics_08February_2015;

import java.util.Scanner;

public class _03LegoBlocks {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);
        int matrixRows = Integer.parseInt(inputScanner.nextLine());

        String[][] firstMatrix = new String[matrixRows][];
        fillMatrix(firstMatrix, inputScanner);
        String[][] secondMatrix = new String[matrixRows][];
        fillMatrix(secondMatrix, inputScanner);

        boolean isRectangleMatrix = false;
        int currentNumberOfCells = firstMatrix[0].length + secondMatrix[0].length;
        int totalNumberOfCells = currentNumberOfCells;
        for (int row = 1; row < matrixRows; row++) {
            isRectangleMatrix = false;
            boolean isFit = firstMatrix[row].length + secondMatrix[row].length == currentNumberOfCells;
            if (isFit) {
                isRectangleMatrix = true;
            }

            totalNumberOfCells += firstMatrix[row].length + secondMatrix[row].length;
        }

        if (isRectangleMatrix) {
            reverseMatrix(secondMatrix);
            String[][] resultMatrix = combineMatrix(firstMatrix, secondMatrix);
            printMatrix(resultMatrix);
        } else {
            System.out.printf("The total number of cells is: %d", totalNumberOfCells);
        }
    }

    private static void fillMatrix(String[][] matrix, Scanner scanner) {
        for (int row = 0; row < matrix.length; row++) {
            matrix[row] = scanner.nextLine().trim().split("\\s+");
        }
    }

    private static void reverseMatrix(String[][] matrix) {
        for (int row = 0; row < matrix.length; row++) {
            String[] currentRow = matrix[row].clone();
            int newCol = 0;
            for (int oldCol = currentRow.length - 1; oldCol >= 0; oldCol--) {
                matrix[row][newCol] = currentRow[oldCol];
                newCol++;
            }
        }
    }

    private static String[][] combineMatrix(String[][] firstMatrix, String[][] secondMatrix) {
        String[][] resultMatrix = new String[firstMatrix.length][];
        for (int row = 0; row < resultMatrix.length; row++) {
            int combinedLength = firstMatrix[row].length + secondMatrix[row].length;
            int secondMatrixCol = 0;
            resultMatrix[row] = new String[combinedLength];
            for (int col = 0; col < combinedLength; col++) {
                if (col < firstMatrix[row].length) {
                    resultMatrix[row][col] = firstMatrix[row][col];
                } else {
                    resultMatrix[row][col] = secondMatrix[row][secondMatrixCol];
                    secondMatrixCol++;
                }
            }
        }

        return resultMatrix;
    }

    private static void printMatrix(String[][] matrix) {
        StringBuilder output = new StringBuilder();
        for (int row = 0; row < matrix.length; row++) {
            output.append("[");
            for (int col = 0; col < matrix[row].length; col++) {
                if (col < matrix[row].length - 1) {
                    output.append(String.format("%s, ", matrix[row][col]));
                } else {
                    output.append(String.format("%s]%n",matrix[row][col]));
                }
            }
        }

        System.out.print(output);
    }
}

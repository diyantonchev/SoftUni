package JavaFundamentals_15November_2015;

import java.util.Scanner;

public class _03RubixsMatrix {
    public static void main(String[] args) {
        Scanner inputScanner = new Scanner(System.in);

        String[] size = inputScanner.nextLine().split("\\s+");
        int rows = Integer.parseInt(size[0]);
        int cols = Integer.parseInt(size[1]);
        int[][] originalMatrix = new int[rows][cols];
        int[][] rubixsMatrix = new int[rows][cols];
        fillMatrix(originalMatrix);
        fillMatrix(rubixsMatrix);

        int commandsCount = Integer.parseInt(inputScanner.nextLine());
        for (int i = 0; i < commandsCount; i++) {
            String[] command = inputScanner.nextLine().split("\\s+");
            String direction = command[1];
            int count = Integer.parseInt(command[2]);
            int row = 0;
            int col = 0;
            switch (direction) {
                case "up":
                    col = Integer.parseInt(command[0]);
                    moveColUp(col, count, rubixsMatrix);
                    break;
                case "down":
                    col = Integer.parseInt(command[0]);
                    moveColDown(col, count, rubixsMatrix);
                    break;
                case "left":
                    row = Integer.parseInt(command[0]);
                    moveRowLeft(row, count, rubixsMatrix);
                    break;
                case "right":
                    row = Integer.parseInt(command[0]);
                    moveRowRight(row, count, rubixsMatrix);
                    break;
            }
        }

        executeSwapCommand(originalMatrix, rubixsMatrix);
    }

    private static void executeSwapCommand(int[][] originalMatrix, int[][] rubixsMatrix) {
        for (int row = 0; row < rubixsMatrix.length; row++) {
            for (int col = 0; col < rubixsMatrix[row].length; col++) {
                if (rubixsMatrix[row][col] == originalMatrix[row][col]) {
                    System.out.println("No swap required");
                } else {
                    boolean hasFound = false;
                    for (int row1 = 0; row1 < rubixsMatrix.length; row1++) {
                        for (int col1 = 0; col1 < rubixsMatrix[row1].length; col1++) {
                            int currentElement = rubixsMatrix[row1][col1];
                            if (currentElement == originalMatrix[row][col]) {
                                System.out.printf("Swap (%d, %d) with (%d, %d)%n", row, col, row1, col1);
                                int temp = rubixsMatrix[row][col];
                                rubixsMatrix[row][col] = rubixsMatrix[row1][col1];
                                rubixsMatrix[row1][col1] = temp;
                                hasFound = true;
                                break;
                            }

                            if (hasFound) {
                                break;
                            }
                        }
                    }
                }
            }
        }
    }

    private static void moveRowRight(int row, int count, int[][] rubixsMatrix) {
        int[] rowValues = new int[rubixsMatrix[row].length];
        int rols = count % rubixsMatrix[row].length;
        for (int col = 0; col < rubixsMatrix[row].length; col++) {
            int newIndex = (col + rols) % rubixsMatrix[row].length;
            rowValues[newIndex] = rubixsMatrix[row][col];
        }

        for (int col = 0; col < rubixsMatrix[row].length; col++) {
            rubixsMatrix[row][col] = rowValues[col];
        }
    }

    private static void moveRowLeft(int row, int count, int[][] rubixsMatrix) {
        int[] rowValues = new int[rubixsMatrix[row].length];
        int rols = count % rubixsMatrix[row].length;
        for (int col = rubixsMatrix[row].length - 1; col >= 0; col--) {
            int newIndex = col - rols;
            if (newIndex < 0) {
                newIndex = rubixsMatrix[row].length + newIndex;
            }
            rowValues[newIndex] = rubixsMatrix[row][col];
        }

        for (int col = 0; col < rubixsMatrix[row].length; col++) {
            rubixsMatrix[row][col] = rowValues[col];
        }
    }

    private static void moveColDown(int col, int count, int[][] rubixsMatrix) {
        int[] colValues = new int[rubixsMatrix.length];
        int rols = count % rubixsMatrix.length;
        for (int row = 0; row < rubixsMatrix.length; row++) {
            int newIndex = (row + rols) % rubixsMatrix.length;
            colValues[newIndex] = rubixsMatrix[row][col];
        }

        for (int row = 0; row < rubixsMatrix.length; row++) {
            rubixsMatrix[row][col] = colValues[row];
        }
    }

    private static void moveColUp(int col, int count, int[][] rubixsMatrix) {
        int[] colValues = new int[rubixsMatrix.length];
        int rols = count % rubixsMatrix.length;
        for (int row = rubixsMatrix.length - 1; row >= 0; row--) {
            int newIndex = row - rols;
            if (newIndex < 0) {
                newIndex = rubixsMatrix.length + newIndex;
            }

            colValues[newIndex] = rubixsMatrix[row][col];
        }

        for (int row = rubixsMatrix.length - 1; row >= 0; row--) {
            rubixsMatrix[row][col] = colValues[row];
        }
    }

    static void fillMatrix(int[][] matrix) {
        int value = 1;
        for (int row = 0; row < matrix.length; row++) {
            for (int col = 0; col < matrix[row].length; col++) {
                matrix[row][col] = value;
                value++;
            }
        }
    }

    static void printMatrix(int[][] matrix) {
        for (int row = 0; row < matrix.length; row++) {
            for (int col = 0; col < matrix[row].length; col++) {
                System.out.printf("%d ", matrix[row][col]);
            }

            System.out.println();
        }
    }
}

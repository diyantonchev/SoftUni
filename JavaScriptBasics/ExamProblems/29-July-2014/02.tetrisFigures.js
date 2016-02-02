function solve(matrix) {
    'use strict';
    var tetriminos, row, col, isI, isJ, isL, isO, isS, isZ, isT;
    tetriminos = {'I': 0, 'L': 0, 'J': 0, 'O': 0, 'Z': 0, 'S': 0, 'T': 0};
    for (row = 0; row < matrix.length - 1; row += 1) {
        for (col = 0; col < matrix[row].length; col += 1) {
            isI = false;
            if (matrix.length - row >= 4) {
                isI = matrix[row][col] === 'o' &&
                    matrix[row + 1][col] === 'o' &&
                    matrix[row + 2][col] === 'o' &&
                    matrix[row + 3][col] === 'o';
            }

            isL = false;
            if (matrix.length - row >= 3 && matrix[row].length - col >= 2) {
                isL = matrix[row][col] === 'o' &&
                    matrix[row + 1][col] === 'o' &&
                    matrix[row + 2][col] === 'o' &&
                    matrix[row + 2][col + 1] === 'o';
            }

            isJ = false;
            if (matrix.length - row >= 3 && col > 0) {
                isJ = matrix[row][col] === 'o' &&
                    matrix[row + 1][col] === 'o' &&
                    matrix[row + 2][col] === 'o' &&
                    matrix[row + 2][col - 1] === 'o';
            }

            isO = false;
            if (matrix.length - row >= 2 && matrix[row].length - col >= 2) {
                isO = matrix[row][col] === 'o' &&
                    matrix[row][col + 1] === 'o' &&
                    matrix[row + 1][col] === 'o' &&
                    matrix[row + 1][col + 1] === 'o';
            }


            isZ = false;
            if (matrix.length - row >= 2 && matrix[row].length - col >= 3) {
                isZ = matrix[row][col] === 'o' &&
                    matrix[row][col + 1] === 'o' &&
                    matrix[row + 1][col + 1] === 'o' &&
                    matrix[row + 1][col + 2] === 'o';
            }

            isS = false;
            if (matrix.length - row >= 2 && matrix[row].length - col >= 2 && col > 0) {
                isS = matrix[row][col] === 'o' &&
                    matrix[row][col + 1] === 'o' &&
                    matrix[row + 1][col] === 'o' &&
                    matrix[row + 1][col - 1] === 'o';
            }

            isT = false;
            if (matrix[row].length - col >= 3) {
                isT = matrix[row][col] === 'o' &&
                    matrix[row][col + 1] === 'o' &&
                    matrix[row][col + 2] === 'o' &&
                    matrix[row + 1][col + 1] === 'o';
            }

            if (isI) {
                tetriminos.I += 1;
            }

            if (isJ) {
                tetriminos.J += 1;
            }

            if (isL) {
                tetriminos.L += 1;
            }

            if (isO) {
                tetriminos.O += 1;
            }

            if (isS) {
                tetriminos.S += 1;
            }

            if (isT) {
                tetriminos.T += 1;
            }

            if (isZ) {
                tetriminos.Z += 1;
            }
        }
    }

    return JSON.stringify(tetriminos);
}
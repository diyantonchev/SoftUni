function solve(matrix) {
    'use strict';

    var row, col, nextCell, nextRow, currentElement, nextElement, i, isSequence = false,
        n = Number(matrix.pop());

    matrix = matrix.map(function (r) {
        return r.split(/\s+/);
    });

    for (row = 0; row < matrix.length; row += 1) {
        for (col = 0; col < matrix[row].length; col += 1) {
            currentElement = matrix[row][col];
            nextRow = row;
            nextCell = col + 1;
            for (i = 1; i < n; i += 1) {
                if (nextCell >= matrix[nextRow].length) {
                    nextCell = 0;
                    nextRow += 1;
                    if (nextRow >= matrix.length) {
                        isSequence = false;
                        break;
                    }
                }

                nextElement = matrix[nextRow][nextCell];
                if (nextElement === currentElement) {
                    isSequence = true;
                    nextCell += 1;
                } else {
                    isSequence = false;
                    break;
                }
            }

            if (isSequence) {
                for (i = 0; i < n; i += 1) {
                    if (col >= matrix[row].length) {
                        col = 0;
                        row += 1;
                        if (row >= matrix.length) {
                            break;
                        }
                    }

                    matrix[row][col] = undefined;
                    col += 1;
                }

                col -= 1;
                isSequence = false;
                if (row >= matrix.length) {
                   break;
                }
            }
        }
    }

    matrix = matrix.map(function (r) {
        return r.filter(function (c) {
            return c !== undefined;
        });
    });

    matrix.forEach(function (r) {
        if (!r.length) {
            console.log('(empty)');
        } else {
            console.log(r.join(' '));
        }
    });
}
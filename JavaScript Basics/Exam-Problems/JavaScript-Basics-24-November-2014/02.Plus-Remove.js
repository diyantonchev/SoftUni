function solve(matrix) {
    'use strict';

    function isPlusShape(up, left, center, right, down) {
        return up === left && left === center && center === right && right === down;
    }

    var row,
        col,
        length = matrix.length,
        result = [];

    matrix.forEach(function (row) {
        result.push(row.split(''));
    });

    for (row = 1; row < length - 1; row += 1) {
        for (col = 1; col < matrix[row].length - 1; col += 1) {
            var up = matrix[row - 1][col] ? matrix[row - 1][col].toLowerCase() : undefined,
                left = matrix[row][col - 1] ? matrix[row][col - 1].toLowerCase() : undefined,
                center = matrix[row][col] ? matrix[row][col].toLowerCase() : undefined,
                right = matrix[row][col + 1] ? matrix[row][col + 1].toLowerCase() : undefined,
                down = matrix[row + 1][col] ? matrix[row + 1][col].toLowerCase() : undefined;

            if (isPlusShape(up, left, center, right, down)) {
                result[row - 1][col] = undefined;
                result[row][col - 1] = undefined;
                result[row][col] = undefined;
                result[row][col + 1] = undefined;
                result[row + 1][col] = undefined;
            }
        }
    }


    result = result.map(function (row) {
        return row.filter(function (col) {
            return col !== undefined;
        });
    });

    result.forEach(function (row) {
        console.log(row.join(''));
    });
}

var matrix = [
    'ab**l5',
    'bBb*555',
    'absh*5',
    'ttHHH',
    'ttth'];
    
solve(matrix);
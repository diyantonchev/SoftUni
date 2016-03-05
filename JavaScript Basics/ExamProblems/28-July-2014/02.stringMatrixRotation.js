function solve(args) {
    'use strict';
    var rotationDegrees = Number(args[0].split(/\(|\)/g)[1]);
    var matrix = [];
    var maxLength = 0;
    delete args[0];
    args.forEach(function (str) {
        if (str.length > maxLength) {
            maxLength = str.length;
        }

        matrix.push(str.split(''));
    });

    matrix.forEach(function (str) {
        while (str.length < maxLength) {
            str.push(' ');
        }
    });

    while (rotationDegrees > 0) {
        matrix = rotateMatrix(matrix);
        rotationDegrees -= 90;
    }

    matrix.forEach(function (str) {
        console.log(str.join(''));
    });

    function rotateMatrix(matrix) {
        var rotatedMatrix = [];
        var colsCount = matrix.length;
        var rowsCount = matrix[0].length;

        for (var row = 0; row < rowsCount; row++) {
            var currentRow = [];
            for (var col = 0; col < colsCount; col++) {
                var rowIndex = colsCount - col - 1;
                var colIndex = row;
                currentRow.push(matrix[colsCount - col - 1][row]);
            }

            rotatedMatrix.push(currentRow);
        }

        return rotatedMatrix;
    }
}
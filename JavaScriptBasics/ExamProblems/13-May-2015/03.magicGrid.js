function solve(args) {
    'use strict';
    function findKey(matrix, magicNumber) {
        var row, col, row1, col1, sum;
        for (row = 0; row < matrix.length; row += 1) {
            for (col = 0; col < matrix[row].length; col += 1) {
                for (row1 = 0; row1 < matrix.length; row1 += 1) {
                    for (col1 = 0; col1 < matrix[row1].length; col1 += 1) {
                        if (row !== row1 || col !== col1) {
                            sum = Number(matrix[row][col]) + Number(matrix[row1][col1]);
                        }

                        if (sum === magicNumber) {
                            return row + col + row1 + col1;
                        }
                    }
                }
            }
        }
    }

    var encryptedMessage, magicNumber, matrix = [], index = 0, key, decryptedMessage = [], i;
    encryptedMessage = args[0];
    magicNumber = Number(args[1]);
    for (i = 2; i < args.length; i += 1) {
        matrix[index] = args[i].split(/\s+/);
        index += 1;
    }

    key = findKey(matrix, magicNumber);
    for (i = 0; i < encryptedMessage.length; i += 1) {
        if (i % 2 === 0) {
            decryptedMessage.push(String.fromCharCode(encryptedMessage[i].charCodeAt(0) + key));
        } else {
            decryptedMessage.push(String.fromCharCode(encryptedMessage[i].charCodeAt(0) - key));
        }
    }

    console.log(decryptedMessage.join(''));
}
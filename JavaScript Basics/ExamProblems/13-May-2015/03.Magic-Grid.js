function solve(args) {
    'use strict';

    function findKey() {
        var key, hasFound;
        for (var row1 = 0; row1 < matrix.length; row1 += 1) {
            for (var col1 = 0; col1 < matrix[row1].length; col1 += 1) {
                for (var row2 = 0; row2 < matrix.length; row2 += 1) {
                    for (var col2 = 0; col2 < matrix[row2].length; col2 += 1) {
                        if (row1 !== row2 || col1 !== col2) {
                            hasFound = Number(matrix[row1][col1]) + Number(matrix[row2][col2]) === magicNumber;
                            if (hasFound) {
                                key = row1 + col1 + row2 + col2;
                                return key;
                            }
                        }
                    }
                }
            }
        }
    }

    var encryptedMessage = args.shift(0),
        magicNumber = Number(args.shift(0)),
        matrix = [],
        key,
        decryptedMessage = [];

    args.forEach(function (row) {
        row = row.split(/\s+/);
        matrix.push(row);
    });

    key = findKey();

    for (var index in encryptedMessage) {
        var newCharCode = encryptedMessage.charCodeAt(index);
        if (index % 2 === 0) {
            newCharCode += key;
        } else {
            newCharCode -= key;
        }

        decryptedMessage.push(String.fromCharCode(newCharCode));
    }

    console.log(decryptedMessage.join(''));
}

var args = [
    'QqdvSpg',
    '400',
    '100 200 120',
    '120 300 310',
    '150 290 370',];

solve(args);
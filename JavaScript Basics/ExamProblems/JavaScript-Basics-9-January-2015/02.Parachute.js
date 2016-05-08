function solve(args) {
    'use strict';

    var row, position;
    args.forEach(function (currentRow, index) {
        var currentPosition = currentRow.indexOf('o');
        if (currentPosition !== -1) {
            row = index;
            position = currentPosition;
        }
    });

    var isOver = false;
    for (row = row + 1; row < args.length; row += 1) {
        var leftArrow = args[row].indexOf('<');
        while (leftArrow !== -1 && leftArrow < args[row].length) {
            if (args[row][leftArrow] === '<') {
                position -= 1;
            }

            leftArrow += 1;
        }

        var rightArrow = args[row].indexOf('>');
        while (rightArrow !== -1 && rightArrow < args[row].length) {
            if (args[row][rightArrow] === '>') {
                position += 1;
            }

            rightArrow += 1;
        }

        switch (args[row][position]) {
            case '_':
                console.log('Landed on the ground like a boss!');
                isOver = true;
                break;
            case '~':
                console.log('Drowned in the water like a cat!');
                isOver = true;
                break;
            case '/':
                console.log('Got smacked on the rock like a dog!');
                isOver = true;
                break;
            case '\\':
                console.log('Got smacked on the rock like a dog!');
                isOver = true;
                break;
            case '|':
                console.log('Got smacked on the rock like a dog!');
                isOver = true;
                break;
            default:
                break;
        }

        if (isOver) {
            break;
        }

    }

    console.log('%s %s', row, position);

}
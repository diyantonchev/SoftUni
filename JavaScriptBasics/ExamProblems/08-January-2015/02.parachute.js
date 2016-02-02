function solve(args) {
    'use strict';
    var row, col, position, currentChar, result, hasFound;
    for (row = 0; row < args.length; row += 1) {
        for (col = 0; col < args[row].length; col += 1) {
            currentChar = args[row][col];
            if (currentChar === 'o') {
                position = col;
                hasFound = true;
                break;
            }

            if (hasFound) {
                if (currentChar === '>') {
                    position += 1;
                }

                if (currentChar === '<') {
                    position -= 1;
                }
            }
        }

        if (hasFound) {
            switch (args[row][position]) {
                case '_':
                    result = 'Landed on the ground like a boss!';
                    break;
                case '~':
                    result = 'Drowned in the water like a cat!';
                    break;
                case '/':
                    result = 'Got smacked on the rock like a dog';
                    break;
                case '\\':
                    result = 'Got smacked on the rock like a dog';
                    break;
                case '|':
                    result = 'Got smacked on the rock like a dog';
                    break;
                default:
                    break;
            }
        }

        if (result !== undefined) {
            console.log(result);
            console.log("%s", row, position);
            break;
        }
    }
}
var args = [
    "--------\\---/------<-----",
    "-->------|o|-------------",
    "----->---|-|-------<-----",
    "---------|>|<------------",
    "->-------/--\\<--->-------",
    "<---<---/----\\---->----><",
    "->>>>--/-<--</----<---<-<",
    "-------\\>>><<\\-----------",
    ">-------\\----/-->--------",
    "---------\\__/------------"
];

solve(args);
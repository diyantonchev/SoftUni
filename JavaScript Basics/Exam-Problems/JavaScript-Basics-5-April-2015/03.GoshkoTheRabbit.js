///ugly as fuck
function solve(args) {
    'use strict';

    var cellsLength = 0,
        result = { '&': 0, '*': 0, '#': 0, '!': 0, 'wall hits': 0 },
        cellsWithVegetables,
        commands = args.shift(0).split(/,\s+/),
        matrix = [];

    args.forEach(function (row) {
        var cells = row.split(/,\s+/);
        cellsLength = cells.length - 1;
        matrix.push(cells);
    });

    var row = 0,
        col = 0,
        oldCol,
        oldRow;
    commands.forEach(function (command) {
        var regex = /{(\!|\*|\&|\#)}/g;
        oldRow = row;
        oldCol = col;
        switch (command) {
            case 'up':
                if (row - 1 < 0) {
                    result['wall hits'] += 1;
                }
                row = Math.max(row - 1, 0);
                break;
            case 'down':
                if (row + 1 > matrix.length - 1) {
                    result['wall hits'] += 1;
                }
                row = Math.min(row + 1, matrix.length - 1);
                break;
            case 'left':
                if (col - 1 < 0) {
                    result['wall hits'] += 1;
                }
                col = Math.max(col - 1, 0);
                break;
            case 'right':
                if (col + 1 > cellsLength) {
                    result['wall hits'] += 1;
                }
                col = Math.min(col + 1, cellsLength);
                break;
            default:
                break;
        }

        var matches = matrix[row][col].match(regex);
        if (matches && (row > 0 || col > 0)) {
            matches.forEach(function (match) {
                var vegetable = match.substring(1, 2);
                result[vegetable] += 1;
                matrix[row][col] = matrix[row][col].replace(match, '@');
            });
        }

        if (oldRow !== row || oldCol !== col) {
            if (!cellsWithVegetables) {
                cellsWithVegetables = matrix[row][col];
            } else {
                cellsWithVegetables += '|' + matrix[row][col];
            }
        }
    });

    console.log(JSON.stringify(result));
    if (!cellsWithVegetables) {
        console.log('no');
    } else {
        console.log(cellsWithVegetables);
    }
}

var args = ['right, up, up, down',
    'asdf, as{#}aj{g}dasd, kjldk{}fdffd, jdflk{#}jdfj',
    'tr{X}yrty, zxx{*}zxc, mncvnvcn, popipoip',
    'poiopipo, nmf{X}d{X}ei, mzoijwq, omcxzne'];

var args = ['up, right, left, down', 'as{!}xnk'];

solve(args);
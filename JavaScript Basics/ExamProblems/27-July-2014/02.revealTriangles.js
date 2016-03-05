function solve(args) {
    var result = [];
    for (var index in args) {
        var currentRow = args[index].split('');
        result.push(currentRow);
    }

    for (var row = 0; row < result.length - 1; row++) {
        for (var col = 1; col < result[row].length; col++) {
            var isTriangle =
                args[row][col] === args[row + 1][col - 1] &&
                args[row][col] === args[row + 1][col] &&
                args[row][col] === args[row + 1][col + 1];
            if (isTriangle) {
                result[row][col] = '*';
                result[row + 1][col - 1] = '*';
                result[row + 1][col] = '*';
                result[row + 1][col + 1] = '*';
            }
        }

        result[row] = result[row].join('');
    }

    result[row] = result[row].join('');
    return result.join('\n');
}
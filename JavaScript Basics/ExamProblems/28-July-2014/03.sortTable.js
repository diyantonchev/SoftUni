function solve(args) {

    var sorted = [];
    var index = 0;
    for (var i = 2; i < args.length - 1; i++) {
        sorted[index] = args[i];
        index++;
    }

    sorted.sort(function (a, b) {
        var regex1 = />([0-9.]+)</g;
        var regex2 = />([0-9.]+)</g;
        var firstMatch = regex1.exec(a);
        var secondMatch = regex2.exec(b);

        var firstPrice = Number(firstMatch[1]);
        var secondPrice = Number(secondMatch[1]);

        return firstPrice - secondPrice;
    });

    sorted = '<table>' + '\n' + '<tr><th>Product</th><th>Price</th><th>Votes</th></tr>' + '\n' + sorted.join('\n') + '\n' + '</table>';
    return sorted;
}

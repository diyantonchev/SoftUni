function solve(args) {
    function isPerfectSquare(number) {
        var s = Math.floor(Math.sqrt(number));
        return (s * s === number);
    }

    function isFibonacci(number) {
        var x = (5 * number * number) + 4;
        var y = (5 * number * number) - 4;

        return isPerfectSquare(x) || isPerfectSquare(y) ? 'yes' : 'no';
    }

    var min = Number(args[0]);
    var max = Number(args[1]);

    var table = ['<table>\n', '<tr><th>Num</th><th>Square</th><th>Fib</th></tr>\n'];
    for (var i = min; i <= max; i++) {
        var row = '<tr><td>{0}</td><td>{1}</td><td>{2}</td></tr>\n'
            .replace('{0}', i)
            .replace('{1}', (i * i).toString())
            .replace('{2}', isFibonacci(i));

        table.push(row);
    }

    table.push('</table>');
    return table.join('');
}
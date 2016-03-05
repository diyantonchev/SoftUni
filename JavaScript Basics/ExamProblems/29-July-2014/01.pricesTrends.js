function solve(args) {
    console.log('<table>');
    console.log('<tr><th>Price</th><th>Trend</th></tr>');
    console.log('<tr><td>%s</td><td><img src="fixed.png"/></td></td>', Number(args[0]).toFixed(2));

    for (var i = 1; i < args.length; i++) {
        var previousNumber = Number(args[i - 1]).toFixed(2);
        var currentNumber = Number(args[i]).toFixed(2);
        if (Number(currentNumber) > Number(previousNumber)) {
            console.log('<tr><td>%s</td><td><img src="up.png"/></td></td>', currentNumber);
        } else if (Number(currentNumber) < Number(previousNumber)) {
            console.log('<tr><td>%s</td><td><img src="down.png"/></td></td>', currentNumber);
        } else {
            console.log('<tr><td>%s</td><td><img src="fixed.png"/></td></td>', currentNumber);
        }
    }

    console.log('</table>');
}
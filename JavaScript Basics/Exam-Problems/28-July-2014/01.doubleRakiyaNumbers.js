function solve(args) {
    var min = Number(args[0]);
    var max = Number(args[1]);

    console.log('<ul>');
    for (var i = min; i <= max; i++) {
        var number = i.toString();
        var hasFound = false;
        for (var j = 1; j < number.length; j++) {
            var firstCouple = number[j - 1] + number[j];

            for (var k = j + 1; k < number.length - 1; k++) {
                var secondCouple = number[k] + number[k + 1];

                if (hasFound) {
                    break;
                }

                if (firstCouple === secondCouple) {
                    console.log('<li><span class=\'rakiya\'>%s</span><a href=\"view.php?id=%s\>View</a></li>', number, number);
                    hasFound = true;
                }
            }
        }

        if (!hasFound) {
            console.log('<li><span class=\'num\'>%s</span></li>', number);
        }
    }

    console.log('</ul>');
}
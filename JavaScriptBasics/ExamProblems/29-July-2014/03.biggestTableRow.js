function solve(args) {
    'use strict';
    var bestSum, finalResult;
    bestSum = -1000001;
    finalResult = '';
    args.forEach(function (row) {
        var hasChanged, result, currentSum, regex;
        regex = /<td>([\d.\-]+)<\/td><td>([\d.\-]+)<\/td><td>([\d.\-]+)<\/td>/g;
        var match;
        while (match = regex.exec(row)) {
            currentSum = 0;
            result = '';
            hasChanged = false;
            if (match[1] && match[1] !== '-' && match[1]) {
                currentSum += Number(match[1]);
                result += match[1];
                hasChanged = true;
            }

            if (match[2] && match[2] !== '-' && match[2]) {
                currentSum += Number(match[2]);
                if (result.length > 0) {
                    result += ' ' + '+' + ' ' + match[2];
                } else {
                    result += match[2];
                }

                hasChanged = true;
            }

            if (match[3] && match[3] !== '-' && match[3]) {
                currentSum += Number(match[3]);
                if (result.length > 0) {
                    result += ' ' + '+' + ' ' + match[3];
                } else {
                    result += match[3];
                }

                hasChanged = true;
            }

            if (currentSum > bestSum && hasChanged) {
                result = currentSum + ' ' + '=' + ' ' + result;
                finalResult = result;
                bestSum = currentSum;
            }
        }
    });

    if (bestSum === -1000001) {
        console.log('no data');
    } else {
        console.log(finalResult);
    }
}
function solve(args) {
    'use strict';

    var minDate = new Date(1900, 1, 0),
        breakDate = new Date(1973, 5, 25),
        maxDate = new Date(2015, 1, 1),
        fanDate, haterDate;

    args.forEach(function (input) {
        var dateParts = input.split(/\./),
            day = dateParts[0],
            month = dateParts[1],
            year = dateParts[2],
            currentDate = new Date(year, Number(month) - 1, Number(day));

        if (minDate < currentDate && currentDate < maxDate) {
            if (currentDate >= breakDate) {
                if (!fanDate || fanDate < currentDate) {
                    fanDate = currentDate;
                }
            } else if (!haterDate || haterDate > currentDate) {
                haterDate = currentDate;
            }
        }
    });

    if (fanDate) {
        console.log('The biggest fan of ewoks was born on %s', fanDate.toDateString());
    }

    if (haterDate) {
        console.log('The biggest hater of ewoks was born on %s', haterDate.toDateString());
    }

    if (!fanDate && !haterDate) {
        console.log('No result');
    }
}

var args = ['22.03.2014', '17.05.1933', '10.10.1954'];
var args = ['01.01.1900',
    '01.02.1900',
    '01.03.1900',
    '01.04.1900',
    '01.05.1900',
    '01.06.1900',
    '31.12.2014',
    '15.11.2456'];
solve(args);
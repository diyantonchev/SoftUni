function solve(args) {
    'use strict';
    var regex = /mine\s+[\w\W]*?\s*-\s+([\w]+\s*:\s*[0-9.]+)/g;
    var silverCount = 0, goldCount = 0, diamondCount = 0;
    args.forEach(function (string) {
        var match, result, ore, quantity;
        while (match = regex.exec(string)) {
            result = match[1].split(/\s*:\s*/);
            ore = result[0];
            quantity = Number(result[1]);
            switch (ore.toLowerCase()) {
                case 'gold':
                    goldCount += quantity;
                    break;
                case 'silver':
                    silverCount += quantity;
                    break;
                case 'diamonds':
                    diamondCount += quantity;
                    break;
                default:
                    break
            }
        }
    });

    console.log('*Silver: %d', silverCount);
    console.log('*Gold: %d', goldCount);
    console.log('*Diamonds: %d', diamondCount);
}
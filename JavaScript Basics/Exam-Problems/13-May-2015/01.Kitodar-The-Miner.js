function solve(args) {
    'use strict';

    var ores = { gold: 0, silver: 0, diamonds: 0 };
    args.forEach(function (input) {
        var info = input.split(/\s*\-\s*/);
        if (info[0].indexOf('mine') !== -1) {
            if (info[1]) {
                var ore = info[1].split(/\s*\:\s*/);
                if (ore.length > 1) {
                    var oreName = ore[0].toLocaleLowerCase();
                    var quantity = Number(ore[1]);
                    if (ores.hasOwnProperty(oreName)) {
                        ores[oreName] += quantity;
                    }
                }
            }
        }
    });

    console.log('*Silver: %s\n*Gold: %s\n*Diamonds: %s', ores.silver, ores.gold, ores.diamonds);
}

var args = [
    'mine bobovDol - gold: 10',
    'mine medenRudnik - silver: 22',
    'mine chernoMore - shrimps : 24',
    'gold: 50',];

solve(args);
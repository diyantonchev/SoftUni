function solve(args) {
    'use strict';
    var luggageInfo = {};
    args.forEach(function (input) {
        var info, ownerName, luggage, isFood, isDrink, isFragile, weight, luggageCarrier, luggageType, criteria;
        if (input.indexOf('*') !== -1) {
            info = input.split(/\.*\*\.*/g);
            ownerName = info[0];
            luggage = info[1];
            isFood = info[2] === 'true';
            isDrink = info[3] === 'true';
            isFragile = info[4] === 'true';
            weight = parseFloat(info[5]);
            luggageCarrier = info[6];
            isFood ? luggageType = 'food' : isDrink ? luggageType = 'drink' : luggageType = 'other';

            if (!luggageInfo[ownerName]) {
                luggageInfo[ownerName] = {};
            }

            luggageInfo[ownerName][luggage] = {
                'kg': weight,
                'fragile': isFragile,
                type: luggageType,
                'transferredWith': luggageCarrier
            };

        } else {
            criteria = input;
            if (criteria === 'luggage name') {
                for (var owner in luggageInfo) {
                    luggageInfo[owner] = sortObjectByKeys(luggageInfo[owner]);
                }

            } else if (criteria === 'weight') {
                var sortedByWeight = {};
                Object.keys(luggageInfo).forEach(function (key) {
                    sortedByWeight[key] = {};
                    var sortedArr = Object.keys(luggageInfo[key]).sort(function (luggage1, luggage2) {
                        return luggageInfo[key][luggage1].kg - luggageInfo[key][luggage2].kg;
                    });

                    sortedArr.forEach(function (luggageName) {
                        sortedByWeight[key][luggageName] = luggageInfo[key][luggageName];
                    });
                });

                luggageInfo = sortedByWeight;
            }
        }
    });

    return JSON.stringify(luggageInfo);

    function sortObjectByKeys(obj) {
        var sortedKeys = Object.keys(obj).sort();
        var sortedObject = {};

        sortedKeys.forEach(function (key) {
            sortedObject[key] = obj[key];
        });

        return sortedObject;
    }
}
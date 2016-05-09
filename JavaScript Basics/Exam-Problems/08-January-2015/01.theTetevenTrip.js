function solve(args) {
    'use strict';
    var fuelCoefficients = {'petrol': 1, 'gas': 1.2, 'diesel': 0.8};
    args.forEach(function (input) {
        var totalConsumption, baseFuelConsumption, extraLuggageFuel, extraSnowFuel;
        baseFuelConsumption = 10;
        var info = input.split(' ');
        var carModel = info[0];
        var fuelType = info[1];
        var routeNumber = info[2];
        var luggageWeight = Number(info[3]);
        baseFuelConsumption *= fuelCoefficients[fuelType.toLowerCase()];
        extraLuggageFuel = luggageWeight * 0.01;
        baseFuelConsumption += extraLuggageFuel;
        extraSnowFuel = 0.3 * baseFuelConsumption;
        if (routeNumber === '1') {
            totalConsumption = 110 * (baseFuelConsumption / 100);
            totalConsumption += 10 * (extraSnowFuel / 100);

        } else if (routeNumber === '2') {
            totalConsumption = 95 * (baseFuelConsumption / 100);
            totalConsumption += 30 * (extraSnowFuel / 100);
        }

        console.log('%s', carModel, fuelType, routeNumber, Math.round(totalConsumption));
    });
}

var args = [
    'BMW petrol 1 320.5',
    'Golf petrol 2 150.75',
    'Lada gas 1 202',
    'Mercedes diesel 2 312.54'
];
solve(args);
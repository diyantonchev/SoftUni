function solve(args) {
    var allConcerts = {};

    args.forEach(function (concert) {
        var info = concert.split(/\s*\|\s*/);
        var band = info[0];
        var town = info[1];
        var venue = info[3];

        if (!allConcerts[town]) {
            allConcerts[town] = {};
        }

        if (!allConcerts[town][venue]) {
            allConcerts[town][venue] = [];
        }

        if (allConcerts[town][venue].indexOf(band) === -1) {
            allConcerts[town][venue].push(band);
        }
    });

    allConcerts = sortObjectByKeys(allConcerts);
    for (var city in allConcerts) {
        allConcerts[city] = sortObjectByKeys(allConcerts[city]);

        for (var venue in allConcerts[city]) {
            allConcerts[city][venue].sort();
        }
    }

    return JSON.stringify(allConcerts);

    function sortObjectByKeys(obj) {
        var sortedKeys = Object.keys(obj).sort();
        var sortedObject = {};

        sortedKeys.forEach(function (key) {
            sortedObject[key] = obj[key];
        });

        return sortedObject;
    }
}
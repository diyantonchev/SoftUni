function solve(args) {
    var matchResults = {};
    args.forEach(function (resultInfo) {
        var tokens = resultInfo.split(/\s*\/\s*|\s*:\s*/g);
        var host = tokens[0];
        var guest = tokens[1];
        var result = tokens[2].split('-');
        var hostGoals = Number(result[0]);
        var guestGoals = Number(result[1]);

        if (!matchResults[host]) {
            matchResults[host] = {
                'goalsScored': 0,
                'goalsConceded': 0,
                'matchesPlayedWith': []
            };
        }

        matchResults[host].goalsScored += hostGoals;
        matchResults[host].goalsConceded += guestGoals;

        if (matchResults[host].matchesPlayedWith.indexOf(guest) === -1) {
            matchResults[host].matchesPlayedWith.push(guest);
        }

        if (!matchResults[guest]) {
            matchResults[guest] = {
                'goalsScored': 0,
                'goalsConceded': 0,
                'matchesPlayedWith': []
            };
        }

        matchResults[guest].goalsScored += guestGoals;
        matchResults[guest].goalsConceded += hostGoals;

        if (matchResults[guest].matchesPlayedWith.indexOf(host) === -1) {
            matchResults[guest].matchesPlayedWith.push(host);
        }
    });

    matchResults = sortObjectByKeys(matchResults);
    for (var country in matchResults) {
        matchResults[country].matchesPlayedWith.sort();
    }

    return JSON.stringify(matchResults);

    function sortObjectByKeys(obj) {
        var sortedKeys = Object.keys(obj).sort();
        var sortedObject = {};

        sortedKeys.forEach(function (key) {
            sortedObject[key] = obj[key];
        });

        return sortedObject;
    }
}
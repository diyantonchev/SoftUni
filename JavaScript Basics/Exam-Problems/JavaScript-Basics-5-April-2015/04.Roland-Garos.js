function solve(args) {
    'use strict';

    var output = [];
    args.forEach(function (input) {
        var matchInfo = input.split(/\s*\:\s*/);
        var players = matchInfo[0].split(/\s*vs\.\s*/);
        var result = matchInfo[1].trim();
        var sets = result.split(/\s+/);
        var player1Name = players[0].trim().replace(/\s+/, ' ');
        var player2Name = players[1].trim().replace(/\s+/, ' ');
        var player1 = output.filter(function (player) { return player.name === player1Name; })[0];
        var player2 = output.filter(function (player) { return player.name === player2Name; })[0];

        if (!player1) {
            player1 = new Player(player1Name);
            output.push(player1);
        }

        if (!player2) {
            player2 = new Player(player2Name);
            output.push(player2);
        }

        var p1SetsWon = 0;
        var p2SetsWon = 0;
        sets.forEach(function (set) {
            var games = set.split('-');
            games = games.map(function (game) {
                return Number(game);
            });

            player1.gamesWon += games[0];
            player1.gamesLost += games[1];
            player2.gamesWon += games[1];
            player2.gamesLost += games[0];

            if (games[0] > games[1]) {
                player1.setsWon += 1;
                player2.setsLost += 1;
                p1SetsWon += 1;
            } else {
                player2.setsWon += 1;
                player1.setsLost += 1;
                p2SetsWon += 1;
            }
        });

        if (p1SetsWon > p2SetsWon) {
            player1.matchesWon += 1;
            player2.matchesLost += 1;
        } else {
            player2.matchesWon += 1;
            player1.matchesLost += 1;
        }

    });

    output = output.sort(function (p1, p2) {
        if (p2.matchesWon !== p1.matchesWon) {
            return p2.matchesWon - p1.matchesWon;
        } else if (p2.setsWon !== p1.setsWon) {
            return p2.setsWon - p1.setsWon;
        } else if (p2.gamesWon !== p1.gamesWon) {
            return p2.gamesWon - p1.gamesWon;
        } else {
            return p1.name.localeCompare(p2.name);
        }
    });

    console.log(JSON.stringify(output));

    function Player(name) {
        this.name = name;
        this.matchesWon = 0;
        this.matchesLost = 0;
        this.setsWon = 0;
        this.setsLost = 0;
        this.gamesWon = 0;
        this.gamesLost = 0;
    }
}

var args = [
    '   Novak               Djokovic   vs.  Roger               Federer   : 6-3 6-3',
    'Roger    Federer    vs.        Novak Djokovic    :         6-2 6-3',
    'Rafael Nadal vs. Andy Murray : 4-6 6-2 5-7',
    'Andy Murray vs. David     Ferrer : 6-4 7-6',
    'Tomas   Bedrych vs. Kei Nishikori : 4-6 6-4 6-3 4-6 5-7',
    'Grigor Dimitrov vs. Milos Raonic : 6-3 4-6 7-6 6-2',
    'Pete Sampras vs. Andre Agassi : 2-1',
    'Boris Beckervs.Andre        Agassi:2-1'
];

solve(args);
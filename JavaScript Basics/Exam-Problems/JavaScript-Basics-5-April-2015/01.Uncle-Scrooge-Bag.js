function solve(args) {
    'use strict';
    var gold,
        silver,
        bronze,
        amount = 0;

    args.forEach(function (couple) {
        var item = couple.split(/\s+/);
        if (item[0].toLocaleLowerCase() === 'coin') {
            var currentAmount = Number(item[1]);
            var isValid = currentAmount > 0 && currentAmount === Math.floor(currentAmount);
            if (isValid) {
                amount += currentAmount;
            }
        }

    });

    gold = Math.floor(amount / 100);
    silver = Math.floor((amount % 100) / 10);
    bronze = Math.floor((amount % 100) % 10);

    console.log('gold : ' + gold);
    console.log('silver : ' + silver);
    console.log('bronze : ' + bronze);  
}

solve();
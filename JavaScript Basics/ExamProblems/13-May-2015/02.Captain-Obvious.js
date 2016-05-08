function solve(args) {
    'use strict';

    var firstText = args.shift(0),
        secondText = args.shift(0);

    var words = firstText.split(/[^A-Za-z]+/);
    var repeatingWords = words.filter(function (w1) {
        var currentRepeatingWords = words.filter(function (w2) {
            return w2.toLowerCase() === w1.toLowerCase();
        });

        if (currentRepeatingWords.length >= 3) {
            return w1;
        }
    });

    if (repeatingWords.length) {

        repeatingWords = repeatingWords.map(function (word) {
            return word.toLowerCase();
        });

        repeatingWords = repeatingWords.filter(function (word, index) {
            return repeatingWords.indexOf(word) === index;
        });

        var result = [];
        var sentences = secondText.match(/[^!?.]+[!.?]/g);
        if (sentences) {
            sentences.forEach(function (sentence) {
                var count = 0;
                var currentWords = sentence.split(/[^A-Za-z]+/);
                currentWords.forEach(function (w1) {
                    repeatingWords.forEach(function (w2) {
                        if (w1.toLowerCase() === w2.toLowerCase()) {
                            count += 1;
                        }
                    });
                });

                if (count >= 2) {
                    result.push(sentence.trim());
                }

            });
        }

        if (result.length) {
            console.log(result.join('\n'));
        } else {
            console.log('No sentences');
        }
    } else {
        console.log('No words');
    }
}

var args = [
    "Captain Obvious was walking down the street. As the captain was walking a person came and told him: You are Captain Obvious! He replied: Thank you CAPTAIN OBVIOUS you are the man!",
    "The captain was walking and he was obvious. He did not know what was going to happen to you in the future. Was he curious? We do not know."];

solve(args);
function solve(args) {
    'use strict';
    function extractRepeatingWords(text) {
        var extractedWords = [];
        var words = text.split(/\W+/g);
        var i, j, count;
        for (i = 0; i < words.length; i += 1) {
            count = 0;
            for (j = i; j < words.length; j += 1) {
                var a = words[i].toLowerCase();
                var b = words[j].toLowerCase();
                if (words[i].toLowerCase() === words[j].toLowerCase()) {
                    count += 1;
                }
            }

            if (count >= 3) {
                if (extractedWords.indexOf(words[i]) === -1) {
                    extractedWords.push(words[i]);
                }
            }
        }

        return extractedWords;
    }

    var text1, text2, repeatingWords, sentences, matched = [];
    text1 = args[0];
    text2 = args[1];
    repeatingWords = extractRepeatingWords(text1);
    if (repeatingWords.length === 0) {
        console.log('No words');
    } else {
        sentences = text2.split(/[?.!]/);
        repeatingWords.forEach(function (word) {
            for (var i = 0; i < sentences.length; i++) {
                if (sentences[i].indexOf(word) !== -1) {
                    if (matched.indexOf(sentences[i]) === -1) {
                        matched.push(sentences[i]);
                    }
                }
            }
        });

        if (matched.length > 0) {
            matched.forEach(function (match) {
                var index = text2.indexOf(match);
                var output = text2.substr(index, match.length + 1);
                console.log(output.trim());
            });
        } else {
            console.log('No sentences');
        }
    }
}

var args = [
    'The words: the and are, are repeated more than three thimes. Look in the second text are there sentences with those words',
    'Yup there are no such sentences.'
];

solve(args);
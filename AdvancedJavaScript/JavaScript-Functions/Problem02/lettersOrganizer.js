function sortLetters(string, ascending) {
    return string.split('').sort(function (x, y) {
        if (ascending) {
            return x.toLocaleLowerCase().localeCompare(y.toLocaleLowerCase());
        } else {
            return y.toLocaleLowerCase().localeCompare(x.toLocaleLowerCase());
        }
    }).join('');
}

//ascending
var ascendingSorted = sortLetters('HelloWorlda', true);
console.log(ascendingSorted)

//descending
var descendingSorted = sortLetters('HelloWorlda', false);
console.log(descendingSorted);
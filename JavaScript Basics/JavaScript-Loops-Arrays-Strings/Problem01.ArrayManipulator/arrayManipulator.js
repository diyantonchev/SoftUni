function ascending(a, b) {
    return a > b;
}

function descending(a, b) {
    return b > a;
}

function findMax(array) {
    array.sort(descending);

    return array[0];
}

function findMin(array) {
    array.sort(ascending);

    return array[0];
}

function findMostFrequent(array) {
    var element, count = 0;
    for (var i = 0; i < array.length; i++) {
        var currentElement = array[i];
        var currentCount = 0;
        for (var j = 0; j < array.length; j++) {
            if (array[j] === currentElement) {
                currentCount++;
            }
        }

        if (currentCount > count) {
            element = currentElement;
            count = currentCount;
        }
    }

    return element;
}

var array = ["Pesho", 2, "Gosho", 12, 2, "true", 9, undefined, 0, "Penka", {bunniesCount: 10}, [10, 20, 30, 40]];

var filtered = array.filter(function (element) {
    return !isNaN(element);
});

var min = findMin(filtered);
var max = findMax(filtered);
var mostFrequent = findMostFrequent(filtered);
filtered.sort(descending);

console.log('Min number: %d\nMax number: %d\nMost frequent number: %d', min, max, mostFrequent);
console.log(filtered);


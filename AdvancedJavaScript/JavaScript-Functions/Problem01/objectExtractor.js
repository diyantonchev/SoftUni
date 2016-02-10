function extractObjects(array) {
    var filteredArray = [];

    for (var index in array) {
        if (typeof(array[index]) === 'object' && !(array[index] instanceof Array)) {
            filteredArray.push(array[index]);
        }
    }

    return filteredArray;
}

var input = [
    "Pesho",
    4,
    4.21,
    {name: 'Valyo', age: 16},
    {type: 'fish', model: 'zlatna ribka'},
    [1, 2, 3],
    "Gosho",
    {name: 'Penka', height: 1.65}
];

var objects = extractObjects(input);
console.log(objects);
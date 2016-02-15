function clone(obj) {
    return JSON.parse(JSON.stringify(obj));
}

function compareObjects(a, b) {
    return a === b;
}

var a = {name: 'Pesho', age: 21}
var b = clone(a); // a deep copy
console.log('a == b --> ' + compareObjects(a, b));

b = a; // not a deep copy
console.log('a == b --> ' + compareObjects(a, b));


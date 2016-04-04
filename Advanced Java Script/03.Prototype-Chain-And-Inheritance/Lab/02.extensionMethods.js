function getRandom() {
    "use strict";
    var randomIndex = (Math.floor(Math.random() * 10)) % this.length;
    return this[randomIndex];
}

Array.prototype.getRandom = getRandom;
String.prototype.getRandom = getRandom;
Object.prototype.getRandom = function () {
    var keys = Object.keys(this);
    var randomKey = keys.getRandom();
    var randomKeyValuePair = {};
    randomKeyValuePair[randomKey] = this[randomKey];
    return randomKeyValuePair;
};

var arr = ['Pesho', 50, 31.6, ['a', 'b', 'c'], {}];
var randomElement = arr.getRandom();
console.log(randomElement);

var str = 'This is an example string';
var randomChar = str.getRandom();
console.log('%s', randomChar !== ' ' ? randomChar : 'space');

var obj = {
    name: "Gosho",
    age: 25,
    grade: 5.95,
    isActive: true,
    languages: ["English", "French"]
};

var randomProperty = obj.getRandom();
console.log(randomProperty);
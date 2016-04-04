String.prototype.startsWith = function (substring) {
    "use strict";
    var substringLength = substring.length;
    if (substringLength > this.length) {
        return false;
    }

    var index;
    for (index = 0; index < substringLength; index += 1) {
        if (substring[index] !== this[index]) {
            return false;
        }
    }

    return true;
};

String.prototype.endsWith = function (substring) {
    "use strict";
    var substringLength, stringLength;
    substringLength = substring.length;
    stringLength = this.length;
    if (substringLength > stringLength) {
        return false;
    }

    var index;
    for (index = 0; index < substringLength; index += 1) {
        if (substring[substringLength - index] !== this[stringLength - index]) {
            return false;
        }
    }

    return true;
};

String.prototype.left = function (count) {
    "use strict";
    if (count < this.length) {
        var index, resultString = [];
        for (index = 0; index < count; index += 1) {
            resultString.push(this[index]);
        }

        return resultString.join('');
    }

    return this.toString();
};

String.prototype.right = function (count) {
    "use strict";
    if (count < this.length) {
        var index, baseString, resultString = [];
        baseString = this.split('').reverse();
        for (index = 0; index < count; index += 1) {
            resultString.push(baseString[index]);
        }

        return resultString.reverse().join('');
    }

    return this.toString();
};


String.prototype.padLeft = function (count, character) {
    "use strict";
    character = character || ' ';
    var counter, resultString, length;
    length = count - this.length;
    resultString = [];
    for (counter = 0; counter < length; counter += 1) {
        resultString.push(character);
    }

    resultString.push(this);
    return resultString.join('');
};

String.prototype.padRight = function (count, character) {
    "use strict";
    character = character || ' ';
    var counter, resultString, pad, length;
    length = count - this.length;
    pad = [];
    resultString = [];
    for (counter = 0; counter < length; counter += 1) {
        pad.push(character);
    }

    resultString.push(this);
    resultString.push(pad.join(''));
    return resultString.join('');
};

String.prototype.repeat = function (count) {
    "use strict";
    var counter, resultString;
    resultString = this.split('');
    for (counter = 1; counter < count; counter += 1) {
        resultString.push(this);
    }

    return resultString.join('');
};

//startsWith Tests
var example = "This is an example string used only for demonstration purposes.";
console.log(example.startsWith("This"));
console.log(example.startsWith("this"));
console.log(example.startsWith("other"));
console.log();

//endsWith Tests
example = "This is an example string used only for demonstration purposes.";
console.log(example.endsWith("poses."));
console.log(example.endsWith("example"));
console.log(example.startsWith("something else"));
console.log();

//left Tests
console.log(example.left(9));
console.log(example.left(90));
console.log();

//right Tests
console.log(example.right(9));
console.log(example.right(90));
console.log();

//padLeft Tests
var hello = "hello";
console.log(hello.padLeft(5));
console.log(hello.padLeft(10));
console.log(hello.padLeft(5, "."));
console.log(hello.padLeft(10, "."));
console.log(hello.padLeft(2, "."));
console.log();


//padRight Tests
hello = "hello";
console.log(hello.padRight(5));
console.log(hello.padRight(10));
console.log(hello.padRight(5, "."));
console.log(hello.padRight(10, "."));
console.log(hello.padRight(2, "."));
console.log();

//repeat Tests
var character = "*";
console.log(character.repeat(5));
console.log("~".repeat(3));
console.log();

// Another combination
console.log("*".repeat(5).padLeft(10, "-").padRight(15, "+"));



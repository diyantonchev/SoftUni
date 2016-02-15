Function.prototype.call = function (object) {
    var args = [];
    for (var i = 1; i < arguments.length; i += 1) {
        args.push(arguments[i]);
    }

    return this.apply(object, args);
};

function sumArguments(a, b) {
    var sum = 0;
    for (var argument in arguments) {
        sum += arguments[argument];
    }

    return sum;
}

var sum  = sumArguments(1, 3, 4);
console.log(sum);
sum = sumArguments.call(null,10, 14);
console.log(sum);

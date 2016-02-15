var Vector = (function () {
    "use strict";
    function Vector(dimensions) {
        if (dimensions.constructor !== Array || dimensions.length < 1) {
            throw new Error('Invalid Vector dimensions.');
        }

        this.dimensions = dimensions;
    }

    Vector.prototype.add = function (otherVector) {
        if (this.dimensions.length !== otherVector.dimensions.length) {
            throw new Error('The two vectors should have the same number of dimensions.');
        }

        var index, sum, resultDimensions, dimensionsCount;
        dimensionsCount = this.dimensions.length;
        resultDimensions = [];
        for (index = 0; index < dimensionsCount; index += 1) {
            sum = this.dimensions[index] + otherVector.dimensions[index];
            resultDimensions.push(sum);
        }

        return new Vector(resultDimensions);
    };

    Vector.prototype.subtract = function (otherVector) {
        if (this.dimensions.length !== otherVector.dimensions.length) {
            throw new Error('The two vectors should have the same number of dimensions.');
        }

        var index, diff, resultDimensions, dimensionsCount;
        dimensionsCount = this.dimensions.length;
        resultDimensions = [];
        for (index = 0; index < dimensionsCount; index += 1) {
            diff = this.dimensions[index] - otherVector.dimensions[index];
            resultDimensions.push(diff);
        }

        return new Vector(resultDimensions);
    };

    Vector.prototype.dot = function (otherVector) {
        if (this.dimensions.length !== otherVector.dimensions.length) {
            throw new Error('The two vectors should have the same number of dimensions.');
        }

        var index, dotProduct, dimensionsCount;
        dimensionsCount = this.dimensions.length;
        dotProduct = 0;
        for (index = 0; index < dimensionsCount; index += 1) {
            dotProduct += this.dimensions[index] * otherVector.dimensions[index];
        }

        return dotProduct;
    };

    Vector.prototype.norm = function () {
        var sum, norm;
        sum = 0;
        this.dimensions.forEach(function (component) {
            sum += component * component;
        });

        norm = Math.sqrt(sum);
        return norm;
    };

    Vector.prototype.toString = function () {
        return '(' + this.dimensions.join(', ') + ')';
    };

    return Vector;
}());

var a = new Vector([1, 2, 3]);
var b = new Vector([4, 5, 6]);
var c = new Vector([1, 1, 1, 1, 1, 1, 1, 1, 1, 1]);

//toSting tests
console.log(a.toString());
console.log(b.toString());
console.log(c.toString());
console.log();

//add test
var result = a.add(b);
console.log(result.toString());
console.log();

//subtract test
result = a.subtract(b);
console.log(result.toString());
console.log();

//dot test
result = a.dot(b);
console.log(result.toString());
console.log();

//norm test
console.log(a.norm());
console.log(b.norm());
console.log(c.norm());
console.log(a.add(b).norm());

// The following throw errors
/****var wrong = new Vector();
 var anotherWrong = new Vector([]);
 a.subtract(c);
 a.add(c);
 a.dot(c);****/






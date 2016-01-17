function calculateRealRoots(a, b, c) {
    var discriminant = b * b - 4 * a * c;
    if (discriminant > 0) {
        var x1 = (-b - Math.sqrt(discriminant)) / (2 * a);
        var x2 = (-b + Math.sqrt(discriminant)) / (2 * a);
        console.log('X1 = %d', x1);
        console.log('X2 = %d', x2);

    } else if (discriminant === 0) {
        var x = (-b + Math.sqrt(discriminant)) / (2 * a);
        console.log('X = %d', x);
    } else {
        console.log('No real roots')
    }
}

var firstEquation = {a: 2, b: 5, c: -3};
var secondEquation = {a: 2, b: -4, c: 2};
var thirdEquation = {a: 4, b: 2, c: 1};

var equations = [firstEquation, secondEquation, thirdEquation];
var index;
for (index in equations) {
    calculateRealRoots(equations[index].a, equations[index].b, equations[index].c);
    console.log('_____________')
}
var inputValues = [20, 112, 400];

for (var index in inputValues) {
    var knots = inputValues[index] / 1.852;
    console.log(knots.toFixed(2));
}
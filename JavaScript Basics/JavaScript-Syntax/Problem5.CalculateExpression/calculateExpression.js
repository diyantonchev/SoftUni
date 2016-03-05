function calculate() {
    var expression = document.getElementById('expression').value;
    var regex = "/[^0-9\-+\/*=()%]/g"
    expression = expression.replace(regex, '');

    var result = eval(expression);
    document.getElementById('result').textContent = result.toString();
}

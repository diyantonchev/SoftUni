function calculateRowValue(row) {
    var firstValue, secondValue, thirdValue, result;

    firstValue = row.firstElementChild.firstElementChild.value;
    secondValue = row.firstElementChild.nextElementSibling.firstElementChild.value;
    thirdValue = row.lastElementChild.firstElementChild.value;

    if (Number(firstValue) && Number(secondValue) && Number(thirdValue)) {
        result = Number(firstValue) + Number(secondValue) + Number(thirdValue);
    }

    return result;
}

function calculateColumnValue(column) {
    var firstValue, secondValue, thirdValue, result;

    firstValue = column[0].firstElementChild.value;
    secondValue = column[1].firstElementChild.value;
    thirdValue = column[2].firstElementChild.value;

    if (Number(firstValue) && Number(secondValue) && Number(thirdValue)) {
        result = Number(firstValue) + Number(secondValue) + Number(thirdValue);
    }

    return result;
}


function appendResultColumn(row) {
    "use strict";
    var resultColumn, resultInputField, result;
    resultColumn = document.createElement('td');
    resultInputField = document.createElement('input');
    resultInputField.type = 'text';

    result = calculateRowValue(row);

    if (result) {
        resultInputField.value = result;
    } else {
        resultInputField.value = 'Wrong input!';
    }

    resultColumn.appendChild(resultInputField);
    row.appendChild(resultColumn);
}

function createResultCell(column) {
    "use strict";
    var resultColumn, resultInputField, result;

    resultColumn = document.createElement('td');
    resultInputField = document.createElement('input');
    resultInputField.type = 'text';

    result = calculateColumnValue(column);

    if (result) {
        resultInputField.value = result;
    } else {
        resultInputField.value = 'Wrong input!';
    }

    resultColumn.appendChild(resultInputField);

    return resultColumn;
}

var firstRow = document.getElementById('firstRow');
var secondRow = document.getElementById('secondRow');
var thirdRow = document.getElementById('thirdRow');

var firstColumn = [firstRow.firstElementChild, secondRow.firstElementChild, thirdRow.firstElementChild];
var secondColumn = [firstRow.firstElementChild.nextElementSibling, secondRow.firstElementChild.nextElementSibling, thirdRow.firstElementChild.nextElementSibling];
var thirdColumn = [firstRow.lastElementChild, secondRow.lastElementChild, thirdRow.lastElementChild];

var isAlreadyClicked = false;
var calculateButton = document.getElementById('calculate');
calculateButton.addEventListener('click', function () {
    "use strict";
    var firstResultCell, secondResultCell, thirdResultCell, resultRow, tableBody;
    resultRow = document.createElement('tr');
    tableBody = document.getElementById('tbody');
    if (!isAlreadyClicked) {
        appendResultColumn(firstRow);
        appendResultColumn(secondRow);
        appendResultColumn(thirdRow);

        firstResultCell = createResultCell(firstColumn);
        secondResultCell = createResultCell(secondColumn);
        thirdResultCell = createResultCell(thirdColumn);

        resultRow.appendChild(firstResultCell);
        resultRow.appendChild(secondResultCell);
        resultRow.appendChild(thirdResultCell);

        tableBody.appendChild(resultRow);

        isAlreadyClicked = true;
    } else {
        location.reload();
    }
}, false);


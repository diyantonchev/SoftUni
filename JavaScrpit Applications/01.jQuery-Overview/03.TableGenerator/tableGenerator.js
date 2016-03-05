$(document).ready(function () {
    "use strict";

    function generateTable() {
        var titles,
            thead,
            tbody,
            table = $('<table>'),
            tableContainer = $('#table-container'),
            info = $.parseJSON($('#json-input').val());

        titles = (function () {
            var titles;

            if (Array.isArray(info)) {
                titles = Object.keys(info[0]);
            } else {
                titles = Object.keys(info);
            }

            return titles;
        }());

        thead = (function () {
            var head = $('<thead>');
            var headRow = $('<tr>');

            titles.forEach(function (title) {
                headRow.append($('<th>').text(title));
            });

            headRow.appendTo(head);

            return head;
        }());

        tbody = (function () {
            var body = $('<tbody>');

            $.each(info, function (index, element) {
                if (!Array.isArray(info)) {
                    if (index === 0) {
                        body.append($('<tr>'));
                    }

                    body.first().append($('<td>').text(element));
                } else {
                    var currentRow = $('<tr>');

                    titles.forEach(function (title) {
                        var cell;

                        if (element[title]) {
                            cell = $('<td>').text(element[title]);
                        } else {
                            cell = $('<td>').text('N/A');
                        }

                        currentRow.append(cell);
                    });

                    body.append(currentRow);
                }
            });

            return body
        }());

        table.append(thead).append(tbody);
        tableContainer.append(table);
    }

    var btn = $('#generate-btn').on('click', generateTable);
});

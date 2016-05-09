function solve(args) {
    'use strict';

    args.forEach(function (input) {
        var queryString = input.split('?');
        if (queryString.length > 1) {
            queryString = queryString[1];
        } else {
            queryString = queryString[0];
        }

        var keyValuePairs = queryString.split('&'),
            result = {};
        keyValuePairs.forEach(function (pair) {
            var current = pair.split('='),
                key = current[0].replace(/%20/g, ' ').replace(/\+/g, ' ').replace(/\s+/g, ' ').trim(),
                value = current[1].replace(/%20/g, ' ').replace(/\+/g, ' ').replace(/\s+/g, ' ').trim();
            if (!result.hasOwnProperty(key)) {
                result[key] = [];
            }
            result[key].push(value);
        });

        var final = '';
        var keys = Object.keys(result);
        for (var key in keys) {
            var currentKey = keys[key];
            var currentValues = result[currentKey].join(', ');
            final += currentKey + '=' + '[' + currentValues + ']';
        }

        console.log(final);
    });
}

var args = [
    'login=student&password=student',
    'field=value1&field=value2&field=value3',
    'http://example.com/over/there?name=ferret',
    'foo=%20foo&value=+val&foo+=5+%20+203',
    'foo=poo%20&value=valley&dog=wow+',
    'url=https://softuni.bg/trainings/coursesinstances/details/1070',
    'https://softuni.bg/trainings.asp?trainer=nakov&course=oop&course=php'];

solve(args);
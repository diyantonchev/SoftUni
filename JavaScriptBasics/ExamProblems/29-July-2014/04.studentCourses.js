function solve(args) {
    'use strict';
    var courses, course;
    courses = {};
    args.forEach(function (input) {
        var info, student, courseName, grade, visits;
        info = input.split(/\s*\|\s*/g);
        student = info[0].trim();
        courseName = info[1].trim();
        grade = info[2].trim();
        visits = info[3].trim();

        if (!courses[courseName]) {
            courses[courseName] = {avgGrade: [], avgVisits: [], students: []};
        }

        courses[courseName].avgGrade.push(grade);
        courses[courseName].avgVisits.push(visits);

        if (courses[courseName].students.indexOf(student) === -1) {
            courses[courseName].students.push(student);
        }
    });

    function sortObjectByKeys(obj) {
        var sortedObject, sortedKeys;

        sortedKeys = Object.keys(obj).sort();
        sortedObject = {};

        sortedKeys.forEach(function (key) {
            sortedObject[key] = obj[key];
        });

        return sortedObject;
    }

    function calculateAverage(arr) {
        var sum = 0.0, average;
        arr.forEach(function (x) {
            sum += Number(x);
        });

        average = sum / arr.length;
        return parseFloat(average.toFixed(2));
    }

    courses = sortObjectByKeys(courses);
    for (course in courses) {
        courses[course].avgGrade = calculateAverage(courses[course].avgGrade);
        courses[course].avgVisits = calculateAverage(courses[course].avgVisits);
        courses[course].students.sort();
    }

    return JSON.stringify(courses);
}
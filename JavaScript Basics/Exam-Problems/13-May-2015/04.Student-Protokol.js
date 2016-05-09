function solve(args) {
    'use strict';

    function Student(studentName, result) {
        this.name = studentName;
        this.result = result;
        this.makeUpExams = 0;
    }

    var exams = {};
    args.forEach(function (input) {
        var info = input.split(/\s*\-\s*/);
        var studentName = info[0].trim();
        var scoreInfo = info[1].trim().split(/\s*\:\s*/);
        var course = scoreInfo[0].trim();
        var score = Number(scoreInfo[1].trim());

        if (!exams.hasOwnProperty(course)) {
            exams[course] = [];
        }

        var scoreIsValid = 0 <= score && score <= 400;
        if (scoreIsValid) {
            var hasCurrentStudent = exams[course].some(function (student) {
                return student.name === studentName;
            });

            var currentStudent;
            if (hasCurrentStudent) {
                currentStudent = exams[course].filter(function (student) {
                    return student.name === studentName;
                })[0];

                if (currentStudent.result < score) {
                    currentStudent.result = score;
                }

                currentStudent.makeUpExams += 1;
            } else {
                currentStudent = new Student(studentName, score);
                exams[course].push(currentStudent);
            }
        }
    });

    var courses = Object.keys(exams);
    courses.sort(function (course1, course2) {
        return exams[course2].length - exams[course1].length;
    });

    var sortedExams = {};
    courses.forEach(function (course) {
        sortedExams[course] = exams[course];
        sortedExams[course].sort(function (s1, s2) {
            if (s2.result !== s1.result) {
                return s2.result - s1.result;
            } else if (s1.makeUpExams !== s2.makeUpExams) {
                return s1.makeUpExams - s2.makeUpExams;
            } else {
                return s1.name.localeCompare(s2.name);
            }
        });
    });

    console.log(JSON.stringify(exams));
}

var args = [
    'Peter Jackson - Java : 350',
    'Jane - JavaScript : 200',
    'Jane     -    JavaScript :     400',
    'Simon Cowell - PHP : 100',
    'Simon Cowell-PHP: 500',
    'Simon Cowell - PHP : 200'
];

solve(args);
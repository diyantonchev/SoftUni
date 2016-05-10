function solve(args) {
    'use strict';

    var courseNameAvg = args.pop().trim(),
        coursePointsAvg = 0,
        count = 0;
    args.forEach(function (input) {
        var info = input.trim().split(/\s+/);
        var student = info[0];
        var course = info[1];
        var examPoints = Number(info[2]);
        var bonusPoints = Number(info[3]);
        var grade;
        var coursePoints;
        if (examPoints < 100) {
            console.log('%s failed at "%s"', student, course);
        } else {
            coursePoints = parseFloat(((examPoints * 0.2) + bonusPoints).toFixed(2));
            grade = ((coursePoints / 80 * 4) + 2).toFixed(2);
            if (grade > 6) {
                grade = (6).toFixed(2);
            }

            console.log('%s: Exam - "%s"; Points - %s; Grade - %s', student, course, coursePoints, grade);
        }

        if (courseNameAvg === course) {
            coursePointsAvg += examPoints;
            count += 1;
        }
    });

    coursePointsAvg = parseFloat((coursePointsAvg / count).toFixed(2));
    console.log('"%s" average points -> %s', courseNameAvg, coursePointsAvg);
}

var args = ['Pesho C#-Advanced 100 3',
    'Gosho Java-Basics 157 3',
    'Tosho HTML&CSS 317 12',
    'Minka C#-Advanced 57 15',
    'Stanka C#-Advanced 157 15',
    'Kircho C#-Advanced 300 0',
    'Niki C#-Advanced 400 10',
    'C#-Advanced'];

solve(args);
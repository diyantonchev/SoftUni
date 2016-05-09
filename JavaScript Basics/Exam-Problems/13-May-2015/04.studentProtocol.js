function solve(args) {
    'use strict';
    var studentProtocol = {}, course, student, score, resultInfo, output = {};
    args.forEach(function (input) {
        var info = input.split(/\s*-\s*/g);
        student = info[0].trim();
        resultInfo = info[1].split(/\s*:\s*/g);
        course = resultInfo[0].trim();
        score = Number(resultInfo[1].trim());

        if (0 <= score && score <= 400) {
            if (!studentProtocol[course]) {
                studentProtocol[course] = {};
            }

            if (!studentProtocol[course][student]) {
                studentProtocol[course][student] = {'name': student, 'result': score, 'makeUpExams': 0}
            } else {
                studentProtocol[course][student].makeUpExams += 1;
                if (score > studentProtocol[course][student].result) {
                    studentProtocol[course][student].result = score;
                }
            }
        }
    });

    for (var course in studentProtocol) {
        output[course] = [];
        for (var student in studentProtocol[course]) {
            output[course].push(studentProtocol[course][student]);
        }
    }

    for (var key in output) {
        output[key] = output[key].sort(function (first, second) {
            if (first.result !== second.result) {
                return second.result - first.result;
            } else if (first.makeUpExams !== second.makeUpExams) {
                return first.makeUpExams - second.makeUpExams;
            } else {
                return first.name.localeCompare(second.name);
            }
        });
    }

    console.log(JSON.stringify(output));
}
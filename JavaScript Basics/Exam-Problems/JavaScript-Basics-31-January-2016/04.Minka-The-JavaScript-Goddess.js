function solve(args) {
    'use strict';

    var examProblems = {};
    args.forEach(function (input) {
        var info = input.split(/\s*&\s*/);
        var name = info[0];
        var type = info[1];
        var taskNumber = 'Task ' + info[2];
        var score = Number(info[3]);
        var linesOfCode = Number(info[4]);
        if (!examProblems[taskNumber]) {
            examProblems[taskNumber] = { tasks: [], average: 0, lines: 0 };
        }

        var currentTask = { name: name, type: type };
        examProblems[taskNumber].tasks.push(currentTask);
        examProblems[taskNumber].average += score;
        examProblems[taskNumber].lines += linesOfCode;
    });

    var keys = Object.keys(examProblems);
    keys.forEach(function (key) {
        examProblems[key].average = parseFloat((examProblems[key].average / examProblems[key].tasks.length).toFixed(2));
        examProblems[key].tasks = examProblems[key].tasks.sort(function (t1, t2) {
            return t1.name.localeCompare(t2.name);
        });
    });

    keys = keys.sort(function (k1, k2) {
        if (examProblems[k1].average !== examProblems[k2].average) {
            return examProblems[k2].average - examProblems[k1].average;
        } else {
            return examProblems[k1].lines - examProblems[k2].lines;
        }
    });

    var output = {};
    keys.forEach(function (key) {
        output[key] = examProblems[key];
    });

    console.log(JSON.stringify(output));
}

var args = ['Array Matcher & strings & 4 & 100 & 38',
    'Magic Wand & draw & 3 & 100 & 15',
    'Dream Item & loops & 2 & 88 & 80',
    'Knight Path & bits & 5 & 100 & 65',
    'Basket Battle & conditionals & 2 & 100 & 120',
    'Torrent Pirate & calculations & 1 & 100 & 20',
    'Encrypted Matrix & nested loops & 4 & 90 & 52',
    'Game of bits & bits & 5 &  100 & 18',
    'Fit box in box & conditionals & 1 & 100 & 95',
    'Disk & draw & 3 & 90 & 15',
    'Poker Straight & nested loops & 4 & 40 & 57',
    'Friend Bits & bits & 5 & 100 & 81'];

solve(args);
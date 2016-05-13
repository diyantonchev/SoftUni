var app = app || {};

(function (schoolSystem) {
    'use strict';

    function Grade(mark, subject, semester) {
        this.setMark(mark);
        this.setSubject(subject);
        this.setSemester(semester);
    }

    Grade.prototype.setMark = function (value) {
        if (isNaN(value)) {
            throw new Error('Invalid mark');
        }

        this._mark = value;
    };

    Grade.prototype.getMark = function () {
        return this._mark;
    };

    Grade.prototype.setSubject = function (value) {
        if (!schoolSystem.Subject.isValidSubject(value)) {
            throw new Error('Invalid subject');
        }

        this._subject = value;
    };

    Grade.prototype.getSubject = function () {
        return this._subject;
    };

    Grade.prototype.setSemester = function (value) {
        if (!(value instanceof schoolSystem.Semester)) {
            throw new Error('Invalid semester');
        }

        this._semester = value;
    };

    Grade.prototype.getSemester = function () {
        return this._semester;
    };


    schoolSystem.Grade = Grade;
} (app));
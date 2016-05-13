var app = app || {};

(function (schoolSystem) {
    'use strict';

    function Semester(name) {
        this.setName(name);
    }

    Semester.prototype.setName = function (value) {
        var regex = /[^A-Za-z\s]+/g,
            isNotValid = regex.test(value);
        if (isNotValid) {
            throw new Error('The semester name should contain only letters and whitespace');
        }

        this._name = value;
    };

    Semester.prototype.getName = function () {
        return this._name;
    };

    schoolSystem.Semester = Semester;
} (app));
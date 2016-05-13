var app = app || {};

(function (schoolSystem) {
    'use strict';

    function Student(name) {
        Student._super.call(this, name);
        this._grades = [];
    }
    
    Student.extends(schoolSystem.Human);

    Student.prototype.getGrades = function () {
        return this._grades;
    };

    Student.prototype.addGrade = function (grade) {
        if (!(grade instanceof schoolSystem.Grade)) {
            throw new Error('Invalid grade');
        }

        this._grades.push(grade);
    };

    schoolSystem.Student = Student;
} (app));
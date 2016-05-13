var app = app || {};

(function (schoolSystem) {
    'use strict';

    function Teacher(name, teachingSubject) {
        Teacher._super.call(this, name);
        this.setTeachingSubject(teachingSubject);
    }

    Teacher.extends(schoolSystem.Human);

    Teacher.prototype.setTeachingSubject = function (value) {
        if (value !== null && !schoolSystem.Subject.isValidSubject(value)) {
            throw new Error('Invalid teaching subject');
        }

        this._teachingSubject = value;
    };

    Teacher.prototype.getTeachingSubject = function () {
        return this._teachingSubject;
    };

    Teacher.prototype.addGradeToStudent = function (student, gradeParams) {
        if (!(student instanceof schoolSystem.Student)) {
            throw new Error('Invalid student');
        }

        var teachingSubjectName = gradeParams.subject;
        var isValidSubject;
        if (teachingSubjectName) {
            isValidSubject = schoolSystem.Subject.isValidSubject(gradeParams.subject);
        } else {
            isValidSubject = false;
        }

        if (!isValidSubject && (this.getTeachingSubject() === null)) {
            throw new Error('Invalid teaching subject');
        }

        if (!isValidSubject) {
            teachingSubjectName = this.getTeachingSubject();
        } else {
            teachingSubjectName = gradeParams.subject;
        }

        var subject = schoolSystem.Subject.getSubjects()[teachingSubjectName];
        var grade = new schoolSystem.Grade(gradeParams.mark, subject, gradeParams.semester);
        student.addGrade(grade);
    };

    schoolSystem.Teacher = Teacher;
} (app));
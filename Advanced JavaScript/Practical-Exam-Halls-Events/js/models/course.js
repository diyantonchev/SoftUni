var app = app || {};

(function (eventsSystem) {
    'use strict';

    function Course(name, numberOfLectures) {
        this.setName(name);
        this.setNumberOfLectures(numberOfLectures);
    }

    Course.prototype.setName = function setName(value) {
        var regex = /[^a-zA-Z\s]+/g,
            isNotValid = regex.test(value);
        if (isNotValid) {
            throw new Error('The course name should contain only letters and whitespace');
        }

        this._name = value;
    };

    Course.prototype.getName = function getName() {
        return this._name;
    };

    Course.prototype.setNumberOfLectures = function setNumberOfLectures(value) {
        if (isNaN(value)){
            throw new Error('Lectures number should be a number (contain only digits)');
        }

        this._numberOfLectures = value;
    };

    Course.prototype.getNumberOfLectures = function getNumberOfLectures(value) {
        return this._numberOfLectures;
    };

    eventsSystem.course = Course;

})(app);
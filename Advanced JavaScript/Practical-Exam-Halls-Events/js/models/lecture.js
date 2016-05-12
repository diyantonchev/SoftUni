var app = app || {};

(function (eventsSystem) {
    'use strict';

    function Lecture(options) {
        Lecture._super.call(this, options);
        this.setTrainer(options.trainer);
        this.setCourse(options.course);
    }

    Lecture.extends(eventsSystem.event);

    Lecture.prototype.setTrainer = function setTrainer(value) {
        if (!(value instanceof eventsSystem.trainer)) {
            throw new Error(value + ' is not a trainer instance');
        }

        this._trainer = value;
    };

    Lecture.prototype.getTrainer = function getTrainer() {
        return this._trainer;
    };

    Lecture.prototype.setCourse = function setCourse(value) {
        if (!(value instanceof eventsSystem.course)) {
            throw new Error(value + ' is not a course instance');
        }

        this._course = value;
    };

    Lecture.prototype.getCourse = function getCourse() {
        return this._course;
    };

    eventsSystem.lecture = Lecture;

})(app);
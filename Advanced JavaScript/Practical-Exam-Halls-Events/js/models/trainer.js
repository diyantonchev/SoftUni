var app = app || {};

(function (eventsSystem) {
    'use strict';
    
    function Trainer(name, workHours) {
        Trainer._super.call(this, name, workHours);
        this.courses = [];
        this.feedbacks = [];
    }

    Trainer.extends(eventsSystem.employee);

    Trainer.prototype.addCourse = function addCourse(course) {
        if (!(course instanceof eventsSystem.course)) {
            throw new Error('');
        }

        this.courses.push(course);
    };

    Trainer.prototype.addFeedback = function addFeedback(feedback) {
        if (typeof feedback !== 'string') {
            throw new Error('The feedback should be string');
        }

        this.feedbacks.push(feedback);
    };

    eventsSystem.trainer = Trainer;

})(app);
var app = app || {};

(function (eventsSystem) {
    'use strict';

    function validStringCheck(value) {
        var isValid = true, regex = /[^a-zA-Z\s]+/g;
        if (regex.test(value)) {
            isValid = false;
        }

        return isValid;
    }

    function Event(options) {
        if (this.constructor === Event) {
            throw new Error('Cannot instantiate abstract class');
        }

        this.setTitle(options.title);
        this.setType(options.type);
        this.setDuration(options.duration);
        this.setDate(options.date);
    }

    Event.prototype.setTitle = function setTitle(value) {
        var isValidTitle = validStringCheck(value);
        if (!isValidTitle) {
            throw new Error('The title should contain only letters and whitespace');
        }

        this._title = value;
    };

    Event.prototype.getTitle = function getTitle() {
        return this._title;
    };

    Event.prototype.setType = function setType(value) {
        var isValidType = validStringCheck(value);
        if (!isValidType) {
            throw new Error('The type should contain only letters and whitespace');
        }

        this._type = value;
    };

    Event.prototype.getType = function getType() {
        return this._type;
    };

    Event.prototype.setDuration = function setDuration(value) {
        if (isNaN(value)) {
            throw new Error('Duration should be a number (contain only digits)');
        }

        this._duration = value;
    };

    Event.prototype.getDuration = function getDuration() {
        return this._duration;
    };

    Event.prototype.setDate = function setDate(value) {
        if (!(value instanceof Date)) {
            throw new Error('Invalid date');
        }

        this._date = value;
    };

    Event.prototype.getDate = function getDate() {
        return this._date;
    };

    eventsSystem.event = Event;
    
})(app);
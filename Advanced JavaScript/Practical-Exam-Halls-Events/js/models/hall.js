var app = app || {};

(function (eventsSystem) {
    'use strict';

    function Hall(name, capacity) {
        this.setName(name);
        this.setCapacity(capacity);
        this.parties = [];
        this.lectures = [];
    }

    Hall.prototype.setName = function setName(value) {
        var regex = /[^A-Za-z\s]+/g,
            isNotValid = regex.test(value);
        if (isNotValid) {
            throw new Error('The hall name should contain only letters and whitespace');
        }

        this._name = value;
    };

    Hall.prototype.getName = function getName() {
        return this._name;
    };

    Hall.prototype.setCapacity = function setCapacity(value) {
        if (isNaN(value)) {
            throw new Error('Capacity should be a number (contain only digits)');
        }

        this._capacity = value;
    };

    Hall.prototype.getCapacity = function getCapacity() {
        return this._capacity;
    };

    Hall.prototype.addEvent = function addEvent(event) {
        if (event instanceof eventsSystem.lecture) {
            this.lectures.push(event);
        } else if (event instanceof eventsSystem.party) {
            this.parties.push(event);
        } else {
            throw new Error('Invalid Event');
        }
    };

    eventsSystem.hall = Hall;
    
})(app);
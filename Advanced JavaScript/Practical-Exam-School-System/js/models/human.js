var app = app || {};

(function (schoolSystem) {
    'use strict';

    function Human(name) {
        if (this.constructor === Human) {
            throw new Error('Cannot instantiate abstract class');
        }

        this.setName(name);
    }

    Human.prototype.setName = function (value) {
        var regex = /[^A-Za-z\s]+/g,
            isNotValid = regex.test(value);
        if (isNotValid) {
            throw new Error('The name should contain only letters and whitespace');
        }

        this._name = value;
    };

    Human.prototype.getName = function () {
        return this._name;
    };

    schoolSystem.Human = Human;
} (app));
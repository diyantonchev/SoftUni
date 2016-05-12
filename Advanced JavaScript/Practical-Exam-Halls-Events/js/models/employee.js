var app = app || {};

(function (eventsSystem) {
    'use strict';
    
    function Employee(name, workHours) {
        this.setName(name);
        this.setWorkhours(workHours);
    }
    
     Employee.prototype.setName = function setName(value) {
        var regex = /[^a-zA-Z\s]+/g,
            isNotValid = regex.test(value);
        if (isNotValid) {
            throw new Error('The employee name should contain only letters and whitespace');
        }

        this._name = value;
    };

    Employee.prototype.getName = function getName() {
        return this._name;
    };

    Employee.prototype.setWorkhours = function setWorkhours(value) {
        if (isNaN(value)){
            throw new Error('Lectures number should be a number (contain only digits)');
        }

        this._workHours = value;
    };

    Employee.prototype.getWorkhours = function getWorkhours(value) {
        return this._workHours;
    };
    
    eventsSystem.employee = Employee;
    
})(app);
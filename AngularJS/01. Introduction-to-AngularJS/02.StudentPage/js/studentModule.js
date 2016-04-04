"use strict";

var app = angular.module('studentPage', []);

app.controller('StudentsController', function StudentsController($scope) {

    var students = [
        {
            name: 'Pesho',
            photo: 'http://www.nakov.com/wp-content/uploads/2014/05/SoftUni-Logo.png',
            grade: 5,
            school: 'High School of Mathematics',
            teacher: 'Gichka Pesheva'
        },
        {
            name: 'Gery-Nikol',
            photo: 'img/gery-nikol.png',
            grade: '6',
            school: 'High School of Deep Throats',
            teacher: 'Krisko'
        }];

    $scope.students = students;
});
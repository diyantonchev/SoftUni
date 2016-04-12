'use strict';

var app = angular.module('videoSystem', ['ngRoute'])
    .config(['$routeProvider', function($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: '../templates/videos-templ.html',
                controller: 'VideoSystemController'
            })
            .when('/add-video', {
                templateUrl: '../templates/add-video-templ.html',
                controller: 'VideoSystemController'
            })
            .otherwise({ redirectTo: '/' });
    }]);
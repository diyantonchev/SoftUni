(function () {
    'use strict';

    angular.module('app.users')
        .controller('RegisterController', RegisterController);

    RegisterController.$inject = ['$location', 'towns', 'authService', 'notifyService'];

    function RegisterController($location, towns, authService, notifyService) {
        var vm = this;

        vm.userData = { townId: null };

        vm.towns = towns.getTowns();

        vm.register = register;

        function register() {
            authService.register(vm.userData, success, error);
        }

        function success() {
            notifyService.showInfo('User registered successfully');
            $location.path('/login');
        }

        function error(err) {
            notifyService.showError('User registration failed', err);
        }
    }

} ());
(function () {
    'use strict';

    angular.module('app.users')
        .controller('LoginController', LoginController);

    LoginController.$inject = ['$location', 'authService', 'notifyService'];

    function LoginController($location, authService, notifyService) {
        var vm = this;

        vm.userData = {};
        vm.login = login;

        function login() {
            authService.login(vm.userData, success, error);
        }

        function success() {
            notifyService.showInfo('Login successful');
            $location.path('/');
        }

        function error(err) {
            notifyService.showError("Login failed. Invalid username or password", err);
        }

    }

} ());
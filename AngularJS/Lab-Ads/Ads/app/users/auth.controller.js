(function () {
    'use strict';
    angular.module('app.users')
        .controller('AuthController', AuthController);

    AuthController.$inject = ['authService', 'notifyService', '$location'];

    function AuthController(authService, notifyService, $location) {
        var vm = this;

        vm.authService = authService;
        vm.logout = logout;

        function logout() {
            authService.logout();
            notifyService.showInfo('Logut successful');
            $location.path('/');
        }
    }
} ());
(function () {
    'use strict';

    angular.module('app')
        .config(configureRoutes)
        .run(authorizationCheck);

    configureRoutes.$inject = ['$routeProvider'];
    authorizationCheck.$inject = ['$rootScope', '$location', 'authService'];

    function configureRoutes($routeProvider) {
        $routeProvider.when('/', {
            templateUrl: 'app/layout/partials/home.html',
            controller: 'HomeController',
            controllerAs: 'vm'
        });

        $routeProvider.when('/register', {
            templateUrl: 'app/users/partials/register.html',
            controller: 'RegisterController',
            controllerAs: 'vm'
        });

        $routeProvider.when('/login', {
            templateUrl: 'app/users/partials/login.html',
            controller: 'LoginController',
            controllerAs: 'vm'
        });


        $routeProvider.when('/user/ads/publish', {
            templateUrl: 'app/users/partials/publish-new-ad.html',
            controller: 'UserPublishNewAdController',
            controllerAs: 'vm'
        });

        $routeProvider.otherwise({
            redirectTo: '/'
        });

    }

    function authorizationCheck($rootScope, $location, authService) {

        $rootScope.$on('$locationChangeStart', function (event) {
            // Authorization check: anonymous site visitors cannot access user routes
            var isAnonymous = $location.path().indexOf("/user/") != -1 && !authService.isLoggedIn();
            if (isAnonymous) {
                $location.path("/");
            }
        });
    }

} ());
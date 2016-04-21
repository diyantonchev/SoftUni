(function () {
    'use strict';

    angular.module('app.users')
        .factory('authService', authService);

    authService.$inject = ['$http', '$q', 'BASE_SERVICE_URL'];

    function authService($http, $q, BASE_SERVICE_URL) {

        var authService = {
            register: register,
            login: login,
            logout: logout,
            getCurrentUser: getCurrentUser,
            isLoggedIn: isLoggedIn,
            isAdmin: isAdmin,
            getAuthHeaders: getAuthHeaders
        };

        return authService;

        function register(userData, success, error) {
            var request = {
                method: 'POST',
                url: BASE_SERVICE_URL + '/api/user/register',
                data: userData
            };

            return $http(request)
                .then(success)
                .catch(function (e) {
                    error(e);
                    return $q.reject(e);
                });
        }

        function login(userData, success, error) {
            var request = {
                method: 'POST',
                url: BASE_SERVICE_URL + '/api/user/login',
                data: userData
            };

            return $http(request)
                .then(function (data) {
                    sessionStorage.currentUser = JSON.stringify(data);
                })
                .then(success)
                .catch(function (e) {
                    error(e);
                    return $q.reject(e);
                });
        }

        function logout() {
            delete sessionStorage.currentUser;
        }

        function getCurrentUser() {
            var currentUser = sessionStorage.currentUser;
            if (currentUser) {
                return JSON.parse(currentUser);
            }
        }

        function isLoggedIn() {
            return sessionStorage.currentUser !== undefined;
        }

        function isAdmin() {
            var currentUser = getCurrentUser();
            return (currentUser !== undefined) && (currentUser.isAdmin);
        }

        function getAuthHeaders() {
            var headers = {};
            var currentUser = getCurrentUser();
            if (currentUser) {
                headers.Authorization = 'Bearer ' + currentUser.data.access_token;
            }

            return headers;
        }
    }
} ());
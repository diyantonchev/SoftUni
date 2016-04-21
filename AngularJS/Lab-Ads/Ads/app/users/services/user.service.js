(function () {
    'use strict';

    angular.module('app.users')
        .factory('user', user);

    user.$inject = ['$http', '$q', 'BASE_SERVICE_URL', 'authService'];

    function user($http, $q, BASE_SERVICE_URL, authService) {

        var userServiceUrl = BASE_SERVICE_URL + '/api/user/ads';
        var headers = authService.getAuthHeaders();

        var user = {
            createNewAd: createNewAd,
            getUserAdds: getUserAdds,
            dectivateAd: dectivateAd,
            publishAgainAd: publishAgainAd
        };

        return user;

        function createNewAd(adData, success, error) {
            var request = {
                method: 'POST',
                url: userServiceUrl,
                headers: headers,
                data: adData
            };

            return $http(request)
                .then(success)
                .catch(function (e) {
                    error();
                    return $q.reject(e);
                });
        }

        function getUserAdds(params, success, error) {
            var request = {
                method: 'GET',
                url: userServiceUrl,
                headers: headers,
                data: params
            };

            return $http(request)
                .then(success)
                .catch(function (e) {
                    error();
                    return $q.reject(e);
                });
        }

        function dectivateAd(id) {
            //TODO
        }

        function publishAgainAd(id) {
            //TODO
        }
    }
} ());
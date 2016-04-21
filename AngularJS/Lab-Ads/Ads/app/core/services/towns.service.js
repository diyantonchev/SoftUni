(function () {
    'use strict';

    angular.module('app.core')
        .factory('towns', towns);

    towns.$inject = ['$resource', 'BASE_SERVICE_URL'];

    function towns($resource, BASE_SERVICE_URL) {
        var townsServiceUrl = BASE_SERVICE_URL + '/api/towns';
        var townsResource = $resource(townsServiceUrl);

        var towns = {
            getTowns: getTowns
        };

        return towns;

        function getTowns(success, error) {
            return townsResource.query(success, error);
        }
    }

} ());
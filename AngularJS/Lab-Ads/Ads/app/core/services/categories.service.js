(function () {
    'use strict';

    angular.module('app.core')
        .factory('categories', categories);

    categories.$inject = ['$resource', 'BASE_SERVICE_URL'];

    function categories($resource, BASE_SERVICE_URL) {
        var categoriesServiceUrl = BASE_SERVICE_URL + '/api/categories';
        var categoriesResource = $resource(categoriesServiceUrl);

        var categories = {
            getCategories: getCategories
        };

        return categories;

        function getCategories(success, error) {
            return categoriesResource.query(success, error);
        }
    }

} ());
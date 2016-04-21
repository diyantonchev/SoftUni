(function () {
    'use strict';

    angular.module('app.core')
        .factory('ads', ads);

    ads.$inject = ['$http', '$resource', 'BASE_SERVICE_URL'];

    function ads($http, $resource, BASE_SERVICE_URL) {
        var adsServiceUrl = BASE_SERVICE_URL + '/api/ads';

        var adsResource = $resource(
            adsServiceUrl,
            null,
            {
                'getAdds': {method: 'GET'}
            }
        );

        var ads = {
            getAdds: getAdds
        };

        return ads;

        function getAdds(addsParams, success, error) {
            return adsResource.getAdds(addsParams, success, error);
        }

        /*  function getAdds(adsParams, success, error) {
         var url = adsServiceUrl + '?pageSize=' + adsParams.pageSize;

         if (adsParams.startPage) {
         url += '&startPage=' + adsParams.startPage;
         }

         if (adsParams.categoryId) {
         url += '&categoryId=' + adsParams.categoryId;
         }

         if (adsParams.townId) {
         url += '&townId=' + adsParams.townId;
         }

         return $http.get(url).then(success).catch(error);
         } */

    }

}());
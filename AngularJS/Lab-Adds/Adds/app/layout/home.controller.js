(function () {
    'use strict';

    angular.module('app.layout')
        .controller('HomeController', HomeController);

    HomeController.$inject = ['ads', 'notifyService', 'PAGE_SIZE', '$scope', '$rootScope'];

    function HomeController(ads, notifyService, PAGE_SIZE, $scope, $rootScope) {
        var vm = this;

        vm.adsParams = {
            startPage: 1,
            pageSize: PAGE_SIZE,
            categoryId: '',
            townId: ''
        };

        vm.reloadAds = reloadAds;
        vm.reloadAds();

        function reloadAds() {
            ads.getAdds(vm.adsParams, success, showError);
        }

        $scope.$on('categoryChanged', function (event, categoryId) {
            vm.adsParams.categoryId = categoryId;
            vm.adsParams.startPage = 1;

            vm.reloadAds();
        });

        $scope.$on('townChanged', function (event, townId) {
            vm.adsParams.townId = townId;
            vm.adsParams.startPage = 1;

            vm.reloadAds();
        });

        function success(data) {
            vm.ads = data;
        }

        function showError(err) {
            notifyService.showError("Cannot load adds", err);
        }
    }

} ());
(function (params) {
    'use strict';

    angular.module('app.users')
        .controller('UserPublishNewAdController', UsersPublishNewAdController);


    UsersPublishNewAdController.$inject = ['$scope', '$location', 'towns', 'categories', 'user', 'notifyService'];

    function UsersPublishNewAdController($scope, $location, towns, categories,
        user, notifyService) {

        var vm = this;

        vm.adData = {
            townId: null,
            categoryId: null,
            title: null,
            text: null,
            imgUrl: null
        };

        vm.categories = categories.getCategories();
        vm.towns = towns.getTowns();

        vm.publishAd = publishAd;

        function publishAd() {
            user.createNewAd(vm.adData, success, error);
        }

        function success() {
            notifyService.showInfo('Advertisement submitted for approval. Once approved, it will be published.');
            $location.path("/user/ads");
        }

        function error(e) {
            notifyService.showError('Publish add failed. Title - The title field is required. Text - The text field is required.', e);
        }

        $scope.fileSelected = function (fileInputField) {
            delete vm.adData.imageDataUrl;
            var file = fileInputField.files[0];
            if (file.type.match(/image\/.*/)) {
                var reader = new FileReader();
                reader.onload = function () {
                    vm.adData.imageDataUrl = reader.result;
                    $(".image-box").html("<img src='" + reader.result + "'>");
                };
                reader.readAsDataURL(file);
            } else {
                $(".image-box").html("<p>File type not supported!</p>");
            }
        };

    }

} ());
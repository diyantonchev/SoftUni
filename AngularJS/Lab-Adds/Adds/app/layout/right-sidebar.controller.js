(function () {
    'use strict';

    angular.module('app.layout')
        .controller('RightSidebarController', RightSidebarController);

    RightSidebarController.$inject = ['categories', 'towns', '$rootScope'];

    function RightSidebarController(categories, towns, $rootScope) {
        var vm = this;

        vm.categories = categories.getCategories();
        vm.towns = towns.getTowns();

        vm.selectedCategoryId = '';
        vm.selectCategory = selectCategory;

        vm.selectedTownId = '';
        vm.selectTown = selectTown;

        function selectCategory(categoryId) {
            vm.selectedCategoryId = categoryId;
            $rootScope.$broadcast('categoryChanged', categoryId);
        }

        function selectTown(townId) {
            vm.selectedTownId = townId;
            $rootScope.$broadcast('townChanged', townId);
        }
    }

} ());
(function () {
    'use strict';
    angular
        .module("app")
        .controller("homeController", homeController);

    homeController.$inject = ["$scope", "genericService"];

    function homeController($scope, genericService) {

        var vm = this;
        vm.$scope = $scope;
        vm.$onInit = _init;
        vm.genericService = genericService;


        function _init() {
            console.log("Home Ctrl Initialized!");
        }



    }
})();
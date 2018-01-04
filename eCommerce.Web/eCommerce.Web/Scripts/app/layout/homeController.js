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
        vm.users = {};

       
        function _init() {
            console.log("Home Ctrl Initialized!");
            _getUsers();
        }

        // accessing user list
        // add this to admin controller 
        function _getUsers() {
            genericService.get("/api/users/")
                .then(_getSuccess)
                .catch(_getFailure);

            function _getSuccess(res) {
                vm.users = res.data.items;
                console.log(res.data.items);
            }

            function _getFailure(err) {
                console.log(err);
            }
        }



    }
})();
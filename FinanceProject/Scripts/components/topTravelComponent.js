(function () {
    'use strict';

    angular.module(appName).component("topTravel", {
        bindings: {},
        templateUrl: "/Scripts/components/views/topTravel.html",
        controller: function (requestService, $scope, $window) {
            var vm = this;
            vm.$onInit = _init;
            vm.travelList = [];

            function _init() {
                requestService.ApiExecute("GET", "/api/WebScrapes/Travel")
                    .then(function (response) {
                        vm.travelList = response;
                    })
                    .catch(function (err) {
                        console.log(err);
                    })
            }

        }
    });
})();
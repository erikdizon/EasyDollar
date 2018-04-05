(function () {
    'use strict';

    angular.module(appName).component("topCashBack", {
        bindings: {},
        templateUrl: "/Scripts/components/views/topCashBack.html",
        controller: function (requestService, $scope, $window) {
            var vm = this;
            vm.$onInit = _init;
            vm.cashBackList = [];

            function _init() {
                requestService.ApiExecute("GET", "/api/WebScrapes/CashBack")
                    .then(function (response) {
                        vm.cashBackList = response;
                    })
                    .catch(function (err) {
                        console.log(err);
                    })
            }

        }
    });
})();
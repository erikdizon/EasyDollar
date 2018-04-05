(function () {
    'use strict';

    angular.module(appName).component("topBalanceTransfer", {
        bindings: {},
        templateUrl: "/Scripts/components/views/topBalanceTransfer.html",
        controller: function (requestService, $scope, $window) {
            var vm = this;
            vm.$onInit = _init;
            vm.balanceTransferList = [];

            function _init() {
                requestService.ApiExecute("GET", "/api/WebScrapes/BalanceTransfer")
                    .then(function (response) {
                        vm.balanceTransferList = response;
                    })
                    .catch(function (err) {
                        console.log(err);
                    })
            }

        }
    });
})();
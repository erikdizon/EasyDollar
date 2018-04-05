(function () {
    'use strict';

    angular.module(appName).component("creditCardHighlights", {
        bindings: {},
        templateUrl: "/Scripts/components/views/creditCardHighlights.html",
        controller: function (requestService, $scope, $window) {
            var vm = this;
            vm.$onInit = _init;
            vm.cardActiveList = [];

            function _init() {
                requestService.ApiExecute("GET", "/api/CreditCards")
                    .then(function (response) {
                        for (var i = 0; i < response.length; i++) {
                            if (response[i].isActive) {
                                vm.cardActiveList.push(response[i]);
                            } 
                        }
                    })
                    .catch(function (err) {
                        console.log(err);
                    })
            }

        }
    });
})();
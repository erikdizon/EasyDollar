(function () {
    'use strict';

    angular.module(appName).component("homeIndex", {
        bindings: {},
        templateUrl: "/Scripts/components/views/homeIndex.html",
        controller: function ($scope, $window) {
            var vm = this;
            vm.$onInit = _init;

            function _init() {
                
            }

        }
    });
})();
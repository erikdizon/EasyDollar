(function () {
    'use strict';

    angular.module(appName).component("login", {
        bindings: {},
        templateUrl: "/Scripts/components/views/login.html",
        controller: function ($scope, $window) {
            var vm = this;
            vm.$onInit = _init;

            function _init() {

            }

        }
    });
})();
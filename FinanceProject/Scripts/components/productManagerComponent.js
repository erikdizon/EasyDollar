(function () {
    'use strict';

    angular.module(appName).component("productManager", {
        bindings: {},
        templateUrl: "/Scripts/components/views/productManager.html",
        controller: function (requestService, $scope, $window) {
            var vm = this;
            vm.$onInit = _init;
            vm.tabOne = "New";
            vm.creditCardModel = {};
            vm.cardActiveList = [];
            vm.cardInactiveList = [];

            vm.submit = _submit;
            vm.edit = _edit;
            vm.update = _update;
            vm.deactivate = _deactivate;
            vm.reactivate = _reactivate;
            vm.delete = _delete;

            function _init() {
                _getCards();
            }

            $scope.$on('cardBag.drop-model', function (e, el, target, source) {

                for (var i = 0; i < vm.cardActiveList.length; i++) {

                    vm.cardActiveList[i].displayOrder = i + 1;

                    requestService.ApiExecute("PUT", "/api/CreditCards/" + vm.cardActiveList[i].id, vm.cardActiveList[i])
                        .then(function (response) {

                        })
                        .catch(function (err) {
                            console.log(err);
                        });

                }

            });

            function _getCards() {
                vm.cardActiveList = [];
                vm.cardInactiveList = [];
                requestService.ApiExecute("GET", "/api/CreditCards")
                    .then(function (response) {
                        for (var i = 0; i < response.length; i++) {
                            if (response[i].isActive) {
                                vm.cardActiveList.push(response[i]);
                            } else {
                                vm.cardInactiveList.push(response[i]);
                            }
                        }
                    })
                    .catch(function (err) {
                        console.log(err);
                    })
            }

            function _submit() {
                requestService.ApiExecute("POST", "/api/CreditCards", vm.creditCardModel)
                    .then(function (response) {
                        vm.creditCardModel = {};
                        swal("New product submitted!", "", "success");
                        _getCards();
                        $scope.active = $scope.index = 2;
                    })
                    .catch(function (err) {
                        console.log(err);
                    })
            }

            function _edit(model) {
                vm.creditCardModel = model;
                $scope.edit = true;
                $scope.active = $scope.index = 1;
                vm.tabOne = "Edit";
            }

            function _update() {
                requestService.ApiExecute("PUT", "/api/CreditCards/" + vm.creditCardModel.id, vm.creditCardModel)
                    .then(function (response) {
                        vm.creditCardModel = {};
                        swal("Product updated!", "", "success");
                        _getCards();
                        $scope.active = $scope.index = 2;
                        $scope.edit = false;
                        vm.tabOne = "New";
                    })
                    .catch(function (err) {
                        console.log(err);
                    })
            }

            function _deactivate(model) {
                model.isActive = false;
                requestService.ApiExecute("PUT", "/api/CreditCards/" + model.id, model)
                    .then(function (response) {
                        _getCards();
                        swal("Product deactivated!");
                    })
                    .catch(function (err) {
                        console.log(err);
                    });
            }

            function _reactivate(model) {
                model.isActive = true;
                model.displayOrder = 1000;
                requestService.ApiExecute("PUT", "/api/CreditCards/" + model.id, model)
                    .then(function (response) {
                        _getCards();
                        swal("Product reactivated!");
                    })
                    .catch(function (err) {
                        console.log(err);
                    });
            }

            function _delete(model) {
                swal({
                    title: "Are you sure you want to delete this product post?",
                    text: "This action cannot be undone!",
                    type: "warning",
                    showCancelButton: true,
                    confirmButtonColor: "#ed5565",
                    confirmButtonText: "Yes, delete!",
                    closeOnConfirm: false
                },
                    function () {
                        requestService.ApiExecute("DELETE", "/api/CreditCards/" + model.id)
                            .then(function (response) {                      
                                _getCards();
                                swal("Product deleted!");
                            })
                            .catch(function (err) {
                                console.log(err);
                            });
                    });
            }
        }
    });
})();
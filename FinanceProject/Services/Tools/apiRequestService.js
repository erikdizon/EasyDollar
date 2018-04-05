(function () {
    'use strict';

    angular.module(appName).factory("requestService", RequestService);
    RequestService.$inject = ["$http", "$q"];

    function RequestService($http, $q) {

        var srv = {
            ApiExecute: _apiExecute
        };

        return srv;

        function _apiExecute(httpType, apiEndPoint, data) {
            switch (httpType) {
                case 'GET':
                    return $http.get(apiEndPoint, { withCredentials: true })
                        .then(function (response) {
                            return response.data;
                        })
                        .catch(function (err) {
                            return $q.reject(err);
                        });
                    break;
                case 'POST':
                    return $http.post(apiEndPoint, data, { withCredentials: true })
                        .then(function (response) {
                            return response.data;
                        })
                        .catch(function (err) {
                            return $q.reject(err);
                        });
                    break;
                case 'PUT':
                    return $http.put(apiEndPoint, data, { withCredentials: true })
                        .then(function (response) {
                            return response.data;
                        })
                        .catch(function (err) {
                            return $q.reject(err);
                        });
                    break;
                case 'DELETE':
                    return $http.delete(apiEndPoint, { withCredentials: true })
                        .then(function (response) {
                            return response.data;
                        })
                        .catch(function (err) {
                            return $q.reject(err);
                        });
                    break;
            }
        }
    }
})();
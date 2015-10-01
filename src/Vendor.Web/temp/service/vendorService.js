(function () {
    'use strict';
    var vendorServices = angular.module('vendorServices', ['ngResource']);

    vendorServices.factory('vendor', ['$resource',
      function ($resource) {
          return $resource('/api/vendor/', {}, {
              query: { method: 'GET', params: {}, isArray: true }
          });
      }]);

})();
(function () {
    'use strict';
    angular
    .module('vendorApp')
    .controller('vendorController', vendorController)

    vendorController.$inject = ['$scope', 'Vendors'];
    function vendorController($scope, Vendors) {
        $scope.vendors = Vendors.query();
    }

})();
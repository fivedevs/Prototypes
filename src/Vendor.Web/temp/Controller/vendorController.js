(function () {
    'use strict';
    angular
    .module('vendorApp')
    .controller('vendorController', vendorController)

    vendorController.$inject = ['$scope', 'Vendor'];
    function vendorController($scope, Vendor) {
        $scope.vendor = Vendor.query();
    }

})();
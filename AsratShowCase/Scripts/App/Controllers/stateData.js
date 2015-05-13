var stateDataApp = angular.module("stateDataApp", ['angularUtils.directives.dirPagination'])
    .controller("stateDataController", function ($scope, $http) {
        $http.get("/angular/States.json").success(function (data) {
            $scope.stateData = data;
        });

        $scope.currentPage = 1;
        $scope.pageSize = 1;       
        
    });


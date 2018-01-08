App.controller('HomeController', function ($scope, $http, $location) {

    $scope.funcionarios = [];

    $http({
        method: 'GET',
        url: '/Funcionario/Listar'
        }).then(function successCallback(response) {
            $scope.funcionarios = response.data;
            console.log($scope.funcionarios);
        }, function errorCallback(response) {
            console.log("não foi possivel listar");
        });
});
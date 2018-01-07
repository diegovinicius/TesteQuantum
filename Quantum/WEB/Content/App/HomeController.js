App.controller('HomeController', function ($scope, $http, $location) {

    $http({
        method: 'GET',
        url: '/Funcionario/Listar'
        }).then(function successCallback(response) {
            console.log(response);
        }, function errorCallback(response) {
            console.log("não foi possivel listar");
        });
});
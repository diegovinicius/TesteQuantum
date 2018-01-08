App.controller('EditarController', function ($scope, $http, $location, $routeParams) {

    $scope.funcionario = {};
    $scope.Id = $routeParams.id;
    $scope.errors = [];

    $http.get(
        '/Funcionario/Buscar',
        { params: { id: $scope.Id } }
    ).then(function successCallback(response) {
        $scope.funcionario = response.data;
        console.log($scope.funcionario);
    }, function errorCallback(response) {
        console.log("não foi possivel listar");
    });


    $scope.salvar = function() {
        if ($scope.funcionarioForm.$valid) {
            $http({
                url: '/Funcionario/Salvar',
                method: "POST",
                data: { funcionario : $scope.funcionario }
            })
            .then(function(response) {
                if (response.status == 200) {
                    new Noty({ text: 'Salvo com sucesso!', type: 'success' }).show();
                    $location.path( "/" );
                } else {
                    new Noty({ text: 'Ocorreu um erro não esperado. Tente novamente.', type: 'error' }).show();
                }
            }, 
            function(response) {
                console.log(response);
            });
        }
    }

    $scope.cancelar = function() {
        $location.path( "/" );
    }
});
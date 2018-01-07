var App = angular.module('appModule', ['ngRoute']);

App
    //HEADERS
    .run(function ($rootScope, $http) {
        //Seta tituo da página.
        $rootScope.Page = {};
        $rootScope.$on('$routeChangeSuccess', function (event, current, previous) {
            $rootScope.Page.title = current.$$route.title;
        });
    })

    //ROTAS
    .config(function ($routeProvider, $locationProvider) {

        $routeProvider
            //HOME
             .when('/', {
                 controller: 'HomeController',
                 templateUrl: 'Content/Views/home.html',

                 title: 'Home',
             })
            .otherwise({ redirectTo: '/' });

        $locationProvider.html5Mode(true);
    });
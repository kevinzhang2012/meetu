﻿(function () {
    "use strict";

    angular.element(document.getElementsByTagName('head')).append(angular.element('<base href="' + window.location.pathname + '" />'));
    angular
        .module("meetupModule")
        .config(route)
        route.$inject = ["$routeProvider", "$locationProvider"]
        function route($routeProvider, $locationProvider) {
            $routeProvider
                .when('/index', {
                    templateUrl: '/Scripts/Views/Meetup/Index.html'
                })
                .when('/Profile/:profileId', {
                    templateUrl: '/Scripts/Views/Profile/profile-display.html'
                })
                .when('/Meetup/Create', {
                    templateUrl: '/Scripts/Views/Meetup/Create.html'
                })
                .otherwise({
                    redirectTo: '/index'
                });
            $locationProvider.html5Mode(({
                enabled: true,
                requireBase: false
            }));
        }
})()
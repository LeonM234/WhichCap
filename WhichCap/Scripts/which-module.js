﻿var whichModule = angular.module('whichApp', ['ngRoute', 'ngResource'])
     .config(function ($routeProvider) {
         $routeProvider.when("/Feed", {
             templateUrl: "/templates/feed.html", controller: "feedController"
         });
         $routeProvider.when("/Profile", {
             templateUrl: "/templates/profile.html", controller: "feedController"
         });
         $routeProvider.otherwise({ redirectTo: "/" });
     });
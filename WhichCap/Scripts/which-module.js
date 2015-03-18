var whichModule = angular.module('whichApp', ['ngRoute', 'ngResource'])
     .config(function ($routeProvider/*$locationProvider*/) {
         $routeProvider.when("/Feed", {
             templateUrl: "/templates/feed.html", controller: "feedController"
         });
         $routeProvider.when("/Profile", {
             templateUrl: "/templates/profile.html", controller: "feedController"
         });
         //$locationProvider.html5Mode(true);
     });
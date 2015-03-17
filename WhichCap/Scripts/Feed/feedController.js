angular.module('whichApp', ['ngRoute'])
     .config(function ($routeProvider/*$locationProvider*/) {
         $routeProvider.when("/Feed", {
             templateUrl: "/templates/feed.html", controller: "feedController"
         });
         $routeProvider.when("/Profile", {
             templateUrl: "/templates/profile.html", controller: "profileController"
         });
         //$locationProvider.html5Mode(true);
     })
    .controller('feedController', function ($http, $scope) {
    });

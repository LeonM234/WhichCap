var whichModule = angular.module('whichApp', ['ngRoute', 'ngResource'])
     .config(function ($routeProvider) {
         $routeProvider.when("/#", {
             templateUrl: "/templates/feed.html", controller: "feedController"
         });
         $routeProvider.when("/Feed", {
             templateUrl: "/templates/feed.html", controller: "feedController"
         });
         $routeProvider.when("/MyWhiches", {
             templateUrl: "/templates/mywhiches.html", controller: "mywhichController"
         });
         $routeProvider.when("/AddWhich", {
             templateUrl: "/templates/addwhich.html", controller: "addController"
         });
         $routeProvider.otherwise({ redirectTo: "/" });
     });
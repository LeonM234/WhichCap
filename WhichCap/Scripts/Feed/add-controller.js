﻿whichModule.controller('addController', function ($scope, feedRepository, $location) {
    $scope.save = function (which) {
        feedRepository.save(which);
        changePath();
        $location.path("Feed");
    }
});

whichModule.controller('feedController', function ($scope, feedRepository, $location) {
    $scope.feeds = feedRepository.get();

    //$scope.save = function (which) {
    //    feedRepository.save(which);
    //    $location.path("Feed");
    //    $scope.feeds = feedRepository.get();
    //    $scope.$apply();
    //}
});

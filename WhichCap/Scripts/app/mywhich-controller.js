whichModule.controller('mywhichController', function ($scope, feedRepository, $location) {
    $scope.feeds = feedRepository.getById();
});

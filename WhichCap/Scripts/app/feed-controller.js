whichModule.controller('feedController', function ($scope, feedRepository, $location) {
    $scope.feeds = feedRepository.get();
    
    // Click 
});

whichModule.controller('feedController', function ($scope, feedRepository, $location) {
    $scope.feeds = feedRepository.get();
    $scope.voteForFirst = function (which) {
        feedRepository.voteForFirst(which);
    };
    $scope.voteForSecond = function (which) {
        feedRepository.voteForSecond(which);
    };
});

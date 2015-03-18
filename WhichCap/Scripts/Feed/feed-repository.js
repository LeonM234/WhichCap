whichModule.factory('feedRepository', function ($resource) {
    return {
        get: function () {
            return $resource('api/feed').get();
            // video uses query(), because that is what you
            // use if you want to return an array, like he does (an array of courses)
            // May want to use this for the actual feed (ALL the data for the feed)?
        }
    }
})
whichModule.factory('feedRepository', function ($resource) {
    return {
        get: function () {
            return $resource('/api/feed').query();
            // query(), because that is what you
            // use if you want to return an array
        },

        save: function (which) {
            return $resource('/api/feed').save(which);
        }
    }
})
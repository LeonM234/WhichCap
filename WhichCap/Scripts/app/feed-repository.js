whichModule.factory('feedRepository', function ($resource, $location) {
    return {
        get: function () {
            return $resource('/api/feed').query();
            // query(), because that is what you
            // use if you want to return an array
        },

        getById: function () {
            return $resource('/api/feed/{id}').query();
        },
        
        save: function (which) {
            return $resource('/api/feed').save(which);
        },

        waitASec: function () {
            window.setTimeout(function () {
                window.location.href = "/#/Feed";
            }, 2000);
        },

        voteForFirst: function (which) {
            $resource('api/' + which.id + '/voteforfirst').save(which.id);
        },

        voteForSecond: function (which) {
            $resource('api/' + which.id + '/voteforsecond').save(which.id);
        }
    }
})
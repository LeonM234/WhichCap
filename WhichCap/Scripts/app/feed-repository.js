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

        // return $resource('/api/feed/{which.id}').put(which);
        // +++ Click whichpic1 or whichpic2
        // +++ ng-click = (feedController function)
        // +++ Runs function to feedController
        // +++ Function should get the ID (available in the angular inspector)
        // +++ Function should grab Vote1 if whichpic1 is selected, else, grab vote2
        // --- add +1 to the value of the appropriate vote
        // --- POST (or update??) the updated vote to the correct ID

        voteForFirst: function (which) {
            $resource('api/' + which.id + '/voteforfirst').save(which.id);
        },

        voteForSecond: function (which) {
            $resource('api/' + which.id + '/voteforsecond').save(which.id);
        }
    }
})
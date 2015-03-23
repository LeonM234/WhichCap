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
            console.log(which.id);
            console.log(which.vote1);
            which.vote1 += 1;
            console.log(which.vote1);
            // return $resource('/api/feed/{which.id}').put(which);
            // +++ Click whichpic1 or whichpic2
            // +++ ng-click = (feedController function)
            // +++ Runs function to feedController
            // +++ Function should get the ID (available in the angular inspector)
            // +++ Function should grab Vote1 if whichpic1 is selected, else, grab vote2
            // --- add +1 to the value of the appropriate vote
            // --- POST (or update??) the updated vote to the correct ID
        },

        voteForSecond: function (which) {
            console.log(which.id);
            console.log(which.vote2);
            which.vote2 += 1;
            console.log(which.vote2);
        }
    }
})
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
        },

        feedVoteDisplay: function (which) {
            // ugly - make modular
            $('.feedVote1').empty();
            $('.feedVote2').empty();
            if (which.vote1 > which.vote2) {
                $('.feedVote1').append("Currently Winning");
                $('.feedVote2').append("Currently Losing");
            }
            else if (which.vote1 < which.vote2) {
                $('.feedVote1').append("Currently Losing");
                $('.feedVote2').append("Currently Winning");
            } 
            else {
                $('.feedVote1').append("Currently TIED!");
                $('.feedVote2').append("Currently TIED!");
            }

        }
    }
})
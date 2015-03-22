whichModule.factory('feedRepository', function ($resource) {
    return {
        get: function () {
            return $resource('/api/feed').query();
            // query(), because that is what you
            // use if you want to return an array
        },

        // may need to change the url 'api/feed/profile' to something else
        // like 'api/profile/:id OR 'api/profile/{id}'
        getById: function () {
            return $resource('/api/feed/{id}').query();
        },
        
        save: function (which) {
            return $resource('/api/feed').save(which);
        }
    }
})
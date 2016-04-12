'use strict';

app.controller('VideoSystemController', ['$scope', 'videoSystemData', function VideoController($scope, videoSystemData) {

    $scope.validUrlRegex = /^(http(?:s)?\:\/\/[a-zA-Z0-9]+(?:(?:\.|\-)[a-zA-Z0-9]+)+(?:\:\d+)?(?:\/[\w\-]+)*(?:\/?|\/\w+\.[a-zA-Z]{2,4}(?:\?[\w]+\=[\w\-]+)?)?(?:\&[\w]+\=[\w\-]+)*)$/g;
    $scope.videos = videoSystemData.getVideos();
    $scope.addVideo = function(video) {
        videoSystemData.addVideo(video);
        var n =/*$('.notification-container').*/noty({
            layout: 'top',
            theme: 'relax',
            text: 'Video successfully added',
            animation: {
                open: { height: 'toggle' },
                close: { height: 'toggle' },
                easing: 'swing',
                speed: 500,
            },
            closeWith: ['hover'],
            killer: true,
        });
    }
}]);
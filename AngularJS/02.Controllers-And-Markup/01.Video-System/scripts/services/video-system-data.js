'use strict';

app.factory('videoSystemData', [function VideoSystemData() {
    var videoSystem = {};

    function addComment(comment) {
        var newComment = {
            username: comment.username || 'Unknown',
            content: comment.content || 'Unknown',
            date: new Date(),
            likes: 0,
            websiteUrl: comment.websiteUrl
        }

        this.comments.push(newComment);
    }

    var videos = [
        {
            title: 'Course introduction',
            pictureUrl: '../img/monkey-04.jpg',
            length: '3:32',
            category: 'IT',
            subscribers: 3,
            date: new Date(2014, 12, 15),
            haveSubtitles: true,
            likes: 0,
            comments: [
                {
                    username: 'Pesho Peshev',
                    content: 'Congratulations Nakov',
                    date: new Date(2014, 12, 15, 12, 30, 0),
                    likes: 3,
                    websiteUrl: 'http://pesho.com/'
                }
            ],
            addComment: addComment
        },
        {
            title: 'Panther Warrior',
            pictureUrl: 'http://vignette1.wikia.nocookie.net/yugioh/images/3/3b/PantherWarrior-TF04-JP-VG-2.jpg/revision/latest?cb=20120829223510',
            length: '15:10',
            category: 'Anime',
            subscribers: 10,
            date: new Date(2016, 4, 8, 9, 27, 30),
            haveSubtitles: false,
            likes: 0,
            comments: [
                {
                    username: 'Yami Bakura',
                    content: 'I summon  Panther Warrior',
                    date: new Date(2014, 12, 15, 12, 30, 0),
                    likes: 3,
                    websiteUrl: 'http://pesho.com/'
                }
            ],
            addComment: addComment
        }];

    videoSystem.getVideos = function() {
        return videos;
    }

    videoSystem.addVideo = function(video) {
        var newVideo = {
            title: video.title,
            pictureUrl: video.pictureUrl,
            length: video.length || '0',
            category: video.category,
            subscribers: 0,
            date: new Date(),
            haveSubtitles: video.haveSubtitles,
            likes: 0,
            comments: [],
            addComment: addComment
        }

        videos.push(newVideo);
    }

    return videoSystem;
}]);
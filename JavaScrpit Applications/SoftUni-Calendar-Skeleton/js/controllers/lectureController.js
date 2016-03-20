var app = app || {};

app.lectureController = (function () {
    "use strict";

    function LectureController(viewBag, model) {
        this.model = model;
        this.viewBag = viewBag;
    }

    LectureController.prototype.loadAddLecture = function (selector) {
        this.viewBag.showAddLecturePage(selector);
    };

    LectureController.prototype.addLecture = function (data) {
        var result = {
            title: data.title,
            start: data.start,
            end: data.end,
            lecturer: sessionStorage['username']
        };

        this.model.addLecture(result)
            .then(function (success) {
                console.log(success);
            });
    };

    LectureController.prototype.loadAllLectures = function (selector) {
        var _this = this;
        this.model.listAllLectures()
            .then(function (data) {
                var result = {
                    lectures: []
                };

                data.forEach(function (lecture) {
                    result.lectures.push({
                        _id: lecture._id,
                        title: lecture.title,
                        start: new Date(lecture.start),
                        end: new Date(lecture.end),
                        lecturer: lecture.lecturer
                    })
                });


                _this.viewBag.showCalendar(selector, result.lectures);
            }).done();
    };

    LectureController.prototype.loadMyLectures = function (selector) {
        var _this = this;
        var userId = sessionStorage['userId'];
        this.model.listMyLectures(userId)
            .then(function (data) {
                var result = {
                    lectures: []
                };

                data.forEach(function (lecture) {
                    result.lectures.push({
                        _id: lecture._id,
                        title: new Date(lecture.title),
                        start: new Date(lecture.start),
                        end: lecture.end,
                        lecturer: lecture.lecturer
                    })
                });

                _this.viewBag.showMyLectures(selector, result.lectures);
            })
    };

    LectureController.prototype.loadEditLecture = function (selector, data) {
        this.viewBag.showEditLecture(selector, data);
    };

    LectureController.prototype.editLecture = function (data) {
        data.lecturer = sessionStorage['username'];
        this.model.editLecture(data._id, data)
            .then(function (success) {
                console.log(success);
            })
    };

    LectureController.prototype.loadDeleteLecture = function (selector, data) {
        this.viewBag.showDeleteLecture(selector, data);
    };

    LectureController.prototype.deleteLecture = function (noteId) {
        this.model.deleteLecture(noteId)
            .then(function (success) {
                console.log(success);
            });
    };

    return {
        load: function (viewBag, model) {
            return new LectureController(viewBag, model);
        }
    };
}());
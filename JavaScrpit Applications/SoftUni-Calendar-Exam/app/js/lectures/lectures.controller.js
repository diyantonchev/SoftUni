var app = app || {};

(function (softUniCalendar) {
    'use strict';

    function LecturesController(model, viewBag, notifier) {
        this.model = model;
        this.viewBag = viewBag;
        this.notifier = notifier;
    }

    LecturesController.prototype.listAll = function listAll(container) {
        var _this = this;
        this.model.listAll().then(
            function success(data) {
                _this.viewBag.showLectures(container, data);
            },
            function error() {

            }).done();
    };

    LecturesController.prototype.listUserLectures = function listUserLectures(container) {
        var userId = sessionStorage.userId;
        var _this = this;
        this.model.listUserLectures(userId).then(
            function success(data) {
                _this.viewBag.showLectures(container, data);
            },
            function error() {

            }).done();
    };

    LecturesController.prototype.loadAddLectureForm = function loadAddLectureForm(container) {
        this.viewBag.showAddLectureForm(container);
    };

    LecturesController.prototype.addLecture = function addLecture(lectureData) {
        var lecture = {
            title: lectureData.title,
            start: lectureData.start,
            end: lectureData.end,
            lecturer: sessionStorage.username
        };

        var _this = this;
        this.model.addLecture(lecture).then(
            function success() {
                _this.notifier.notifySuccess('Successfully added lecture');
                Sammy(function () {
                    this.trigger('redirectUrl', { url: '#/calendar/my/' });
                });
            },
            function error(data) {
                console.error(data);
                _this.notifier.notifyError('Invalid data');
            }).done();
    };

    LecturesController.prototype.loadEditLectureForm = function loadEditLectureForm(container, data) {
        this.viewBag.showEditLectureForm(container, data);
    };

    LecturesController.prototype.editLecture = function editLecture(data) {
        var id = data._id;
        var lecture = {
            title: data.title,
            start: data.start,
            end: data.end,
            lecturer: sessionStorage.username
        };
        var _this = this;
        this.model.editLecture(id, lecture).then(
            function success() {
                _this.notifier.notifySuccess('Lecture successfully edited');
                Sammy(function () {
                    this.trigger('redirectUrl', { url: '#/calendar/my/' });
                });
            },
            function error(data) {
                console.error(data);
                _this.notifier.notifyError('Invalid data');
            }).done();
    };

    LecturesController.prototype.loadDeleteLectureForm = function loadDeleteLectureForm(container, data) {
        this.viewBag.showDeleteLectureForm(container, data);
    };

    LecturesController.prototype.deleteLecture = function deleteLecture(data) {
        var _this = this;
        this.model.deleteLecture(data).then(
            function success() {
                _this.notifier.notifySuccess('Lecture successfully deleted');
                Sammy(function () {
                    this.trigger('redirectUrl', { url: '#/calendar/my/' });
                });
            },
            function error() {
                console.error(data);
                _this.notifier.notifyError('Invalid data');
            }).done();
    };

    softUniCalendar.lecturesController = {
        load: function (model, viewBag, notifier) {
            return new LecturesController(model, viewBag, notifier);
        }
    };

})(app);
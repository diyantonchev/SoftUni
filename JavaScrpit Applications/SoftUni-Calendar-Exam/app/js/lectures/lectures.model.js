var app = app || {};

(function (softUniCalendar) {
    'use strict';

    function LecturesModel(requester) {
        this.requester = requester;
        this.setServiceUrl(requester.baseUrl, requester.appId);
    }

    LecturesModel.prototype.setServiceUrl = function setServiceUrl(baseUrl, appId) {
        this._serviceUrl = baseUrl + '/appdata/' + appId + '/lectures/';
    };

    LecturesModel.prototype.listAll = function listAll() {
        var requestUrl = this._serviceUrl;
        return this.requester.get(requestUrl);
    };

    LecturesModel.prototype.listUserLectures = function listUserLectures(userId) {
        var requestUrl = this._serviceUrl + '?query={"_acl.creator":"' + userId + '"}';
        return this.requester.get(requestUrl);
    };

    LecturesModel.prototype.addLecture = function addLecture(lecture) {
        var requestUrl = this._serviceUrl;
        return this.requester.post(requestUrl, lecture);
    };

    LecturesModel.prototype.editLecture = function editLecture(lectureId, editedLecture) {
        var requestUrl = this._serviceUrl + lectureId;
        return this.requester.put(requestUrl, editedLecture);
    };

    LecturesModel.prototype.deleteLecture = function deleteLecture(lectureId) {
        var requestUrl = this._serviceUrl + lectureId;
        return this.requester.del(requestUrl);
    };

    softUniCalendar.lecturesModel = {
        load: function (requester) {
            return new LecturesModel(requester);
        }
    };

})(app);
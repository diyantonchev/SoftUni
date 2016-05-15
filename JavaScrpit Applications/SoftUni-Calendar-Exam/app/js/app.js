var app = app || {};

(function (softUniCalendar) {
    'use strict';

    var menu = '#menu';
    var container = '#container';

    var constants = softUniCalendar.constants;
    var requester = softUniCalendar.requester.config(constants.baseUrl, constants.appKey, constants.appSecret);
    var notifier = softUniCalendar.notifier;

    var userModel = softUniCalendar.userModel.load(requester);
    var lecturesModel = softUniCalendar.lecturesModel.load(requester);

    var homeViewBag = softUniCalendar.homeViewBag;
    var userViewBag = softUniCalendar.userViewBag;
    var lecturesViewBag = softUniCalendar.lecturesViewBag;

    var homeController = softUniCalendar.homeController.load(homeViewBag);
    var userController = softUniCalendar.userController.load(userModel, userViewBag, notifier);
    var lecturesController = softUniCalendar.lecturesController.load(lecturesModel, lecturesViewBag, notifier);

    var router = Sammy(function () {

        this.before({ except: { path: '#\/(login\/|register\/)?' } }, function () {
            if (!sessionStorage.authtoken) {
                this.redirect('#/');
                return false;
            }
        });

        this.before(function () {
            if (!sessionStorage.authtoken) {
                homeController.loadLoginMenu(menu);
            } else {
                homeController.loadHomeMenu(menu);
            }
        });

        this.get('#/', function () {
            if (!sessionStorage.authtoken) {
                homeController.loadWelcomeGuest(container);
            } else {
                homeController.loadWelcomeUser(container);
            }
        });

        this.get('#/register/', function () {
            userController.loadRegisterForm(container);
        });

        this.get('#/login/', function () {
            userController.loadLoginForm(container);
        });

        this.get('#/logout/', function () {
            userController.logout();
        });

        this.get('#/calendar/list/', function () {
            lecturesController.listAll(container);
        });

        this.get('#/calendar/my/', function () {
            lecturesController.listUserLectures(container);
        });

        this.get('#/calendar/add/', function () {
            lecturesController.loadAddLectureForm(container);
        });

        this.get('#/calendar/edit/:lectureId', function (data) {
            var info = {};
            info._id = data.params._id;
            info.title = data.params.title;
            info.start = data.params.start;
            info.end = data.params.end;
            info.lecturer = data.params.lecturer;
            lecturesController.loadEditLectureForm(container, info);
        });

        this.get('#/calendar/delete/:id', function (data) {
            console.log(data.params);
            var info = {};
            info._id = data.params._id;
            info.title = data.params.title;
            info.start = data.params.start;
            info.end = data.params.end;
            info.lecturer = data.params.lecturer;
            lecturesController.loadDeleteLectureForm(container, info);
        });

        this.bind('login', function (event, user) {
            userController.login(user);
        });

        this.bind('registerUser', function (event, user) {
            userController.registerUser(user);
        });

        this.bind('redirectUrl', function (event, data) {
            this.redirect(data.url, data.data);
        });

        this.bind('addLecture', function (event, data) {
            lecturesController.addLecture(data);
        });

        this.bind('editLecture', function (event, data) {
            lecturesController.editLecture(data);
        });

        this.bind('deleteLecture', function (event, data) {
            lecturesController.deleteLecture(data._id);
        });

    });

    router.run('#/');

})(app);
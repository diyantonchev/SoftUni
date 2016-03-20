var app = app || {};


(function () {
    "use strict";

    var router = Sammy(function () {
        var menuSelector = '#menu';
        var sectionSelector = '#container';
        var requester = app.requester.load('kid_Zyd9ciHak-', 'f6f8a8e4001545a6a8a7f25aee417e76', 'https://baas.kinvey.com/');

        var homeViewBag = app.homeViewBag.load();
        var userViewBag = app.userViewBag.load();
        var lectureViewBag = app.lectureViewBag.load();

        var userModel = app.userModel.load(requester);
        var lectureModel = app.lecturesModel.load(requester);


        var homeController = app.homeController.load(homeViewBag);
        var userController = app.userController.load(userViewBag, userModel);
        var lectureController = app.lectureController.load(lectureViewBag, lectureModel);

        this.get('#/', function () {
            if (!sessionStorage.sessionId) {
                this.redirect('#/welcome-guest');
            } else {
                this.redirect('#/welcome-user');
            }
        });

        this.get('#/welcome-guest', function () {
            homeController.loadWelcomeGuestPage(sectionSelector, menuSelector);
        });

        this.get('#/welcome-user', function () {
            homeController.loadWelcomeUserPage(sectionSelector, menuSelector);
        });


        this.get('#/login/', function () {
            userController.loadLoginPage(sectionSelector);
        });

        this.get('#/register/', function () {
            userController.loadRegisterPage(sectionSelector);
        });

        this.get('#/logout/', function () {
            userController.logout();
        });

        this.get('#/calendar/list/', function(){

            lectureController.loadAllLectures(sectionSelector);
        });

        this.get('#/calendar/add/', function () {
            lectureController.loadAddLecture(sectionSelector);
        });

        this.get('#/calendar/my/', function(){
            lectureController.loadMyLectures(sectionSelector);
        });

        this.bind('redirectUrl', function (ev, data) {
            this.redirect(data.url);
        });

        this.bind('login', function (ev, data) {
            userController.login(data);
        });

        this.bind('register', function (ev, data) {
            userController.register(data);
        });

        this.bind('addLecture', function (ev, data) {
            lectureController.addLecture(data);
        });

        this.bind('editLecture', function (ev, data) {
            lectureController.editLecture(data);
        });

        this.bind('deleteLecture', function (ev, data) {
            lectureController.deleteLecture(data);
        });
    });

    router.run('#/');
}());

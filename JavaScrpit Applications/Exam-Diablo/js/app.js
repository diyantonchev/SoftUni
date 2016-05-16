var app = app || {};

(function (diablo) {
    'use strict';

    var menu = '#menu';
    var container = '#container';

    var constants = diablo.constants;
    var requester = diablo.requester.config(constants.baseUrl, constants.appKey, constants.appSecret);
    var notifier = diablo.notifier;

    var userModel = diablo.userModel.load(requester);
    var heroClassesModel = diablo.heroClassesModel.load(requester);
    var heroesModel = diablo.heroesModel.load(requester);
    var itemsModel = diablo.itemsModel.load(requester);

    var homeViewBag = diablo.homeViewBag;
    var userViewBag = diablo.userViewBag;
    var heroesViewBag = diablo.heroesViewBag;

    var homeController = diablo.homeController.load(homeViewBag);
    var userController = diablo.userController.load(userModel, userViewBag, notifier);
    var heroesController = diablo.heroesController.load(heroesModel, heroClassesModel, itemsModel, heroesViewBag, notifier);

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

        this.get('#/heroes/list/', function () {
            heroesController.listUsersHeroes(container);
        });

        this.get('#/heroes/add/', function () {
            heroesController.loadAddHero(container);
        });

        this.get('#/heroes/:heroId', function (data) {
            var id = data.params.heroId;
            heroesController.loadHeroPage(id, container);
        });

        this.get('#/heroes/:heroId/store', function (data) {
            var id = data.params.heroId;
            heroesController.loadStore(id, container);
        });

        this.bind('addHero', function (event, data) {
            heroesController.addHero(data);
        });

        this.bind('addItem', function (event, data) {
            heroesController.addItem(data);
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

    });

    router.run('#/');

})(app);
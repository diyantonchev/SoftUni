var app = app || {};

(function (diablo) {
    'use strict';
    function HomeController(viewBag) {
        this.viewBag = viewBag;
    }

    HomeController.prototype.loadHomeMenu = function loadHomeMenu(menu) {
        this.viewBag.showHomeMenu(menu);
    };

    HomeController.prototype.loadLoginMenu = function loadLoginMenu(menu) {
        this.viewBag.showLoginMenu(menu);
    };

    HomeController.prototype.loadWelcomeUser = function loadWelcomeUser(container) {
        var data = {
            username: sessionStorage.username
        };

        this.viewBag.showWelcomeUser(container, data);
    };

    HomeController.prototype.loadWelcomeGuest = function loadWelcomeUser(container) {
        this.viewBag.showWelcomeGuest(container);
    };

    app.homeController = {
        load: function (viewBag) {
            return new HomeController(viewBag);
        }
    };

})(app);
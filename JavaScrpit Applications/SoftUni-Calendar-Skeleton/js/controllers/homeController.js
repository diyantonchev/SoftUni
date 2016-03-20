var app = app || {};

app.homeController = (function () {
    "use strict";

    function HomeController(viewBag) {
        this.viewBag = viewBag;
    }

    HomeController.prototype.loadWelcomeGuestPage = function (sectionSelector, menuSelector) {
        this.viewBag.showWelcomeGuestPage(sectionSelector, menuSelector);
    };

    HomeController.prototype.loadWelcomeUserPage = function (sectionSelector, menuSelector) {
        var data = {
            username: sessionStorage['username']
        };

        this.viewBag.showWelcomeUserPage(sectionSelector, menuSelector, data);
    };

    return {
        load: function (viewBag) {
            return new HomeController(viewBag);
        }
    }
}());
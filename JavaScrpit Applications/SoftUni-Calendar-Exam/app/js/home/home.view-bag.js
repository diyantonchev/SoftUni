var app = app || {};

(function (softUniCalendar) {
    'use strict';

    function showHomeMenu(menu) {
        $.get('templates/menu-home.html', function (template) {
            $(menu).html(template);
        });
    }

    function showLoginMenu(menu) {
        $.get('templates/menu-login.html', function (template) {
            $(menu).html(template);
        });
    }

    function showWelcomeUser(container, data) {
        $.get('templates/welcome-user.html', function (template) {
            var rendered = Mustache.render(template, data);
            $(container).html(rendered);
        });
    }

    function showWelcomeGuest(container) {
        $.get('templates/welcome-guest.html', function (template) {
            $(container).html(template);
        });
    }

    softUniCalendar.homeViewBag = {
        showHomeMenu: showHomeMenu,
        showLoginMenu: showLoginMenu,
        showWelcomeUser: showWelcomeUser,
        showWelcomeGuest: showWelcomeGuest
    };

})(app);
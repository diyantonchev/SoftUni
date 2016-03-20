var app = app || {};

app.homeViewBag = (function () {
    "use strict";

    function showWelcomeGuestPage(sectionSelector, menuSelector) {
        $.get('templates/welcome-guest.html', function (templ) {
            $(sectionSelector).html(templ);
        }).then(
            $.get('templates/menu-login.html', function (temp) {
                $(menuSelector).html(temp);
            })
        ).done();
    }

    function showWelcomeUserPage(sectionSelector, menuSelector, data) {
        $.get('templates/welcome-user.html', function (templ) {
            var rendered = Mustache.render(templ, data);
            $(sectionSelector).html(rendered);
        }).then(
            $.get('templates/menu-home.html', function (temp) {
                $(menuSelector).html(temp);
            })
        ).done();
    }

    return {
        load: function () {
            return {
                showWelcomeGuestPage: showWelcomeGuestPage,
                showWelcomeUserPage: showWelcomeUserPage
            }
        }
    }
}());
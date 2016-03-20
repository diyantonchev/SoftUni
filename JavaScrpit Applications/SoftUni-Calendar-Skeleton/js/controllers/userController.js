var app = app || {};

app.userController = (function () {
    "use strict";

    function UserController(viewBag, model) {
        this.viewBag = viewBag;
        this.model = model;
    }

    UserController.prototype.loadLoginPage = function (selector) {
        this.viewBag.showLoginPage(selector);
    };

    UserController.prototype.login = function (data) {
        return this.model.login(data)
            .then(function (success) {
                sessionStorage['sessionId'] = success._kmd.authtoken;
                sessionStorage['username'] = success.username;
                sessionStorage['userId'] = success._id;

                Sammy(function () {
                    this.trigger('redirectUrl', {url: '#/welcome-user'});
                });

            }).done();
    };


    UserController.prototype.loadRegisterPage = function (selector) {
        this.viewBag.showRegisterPage(selector);
    };

    UserController.prototype.register = function (data) {
        if (data.password === data.confirm) {

            var user = {username: data.username, password: data.password};
            return this.model.register(user)
                .then(function (success) {
                    sessionStorage['sessionId'] = success._kmd.authtoken;
                    sessionStorage['username'] = success.username;
                    sessionStorage['fullName'] = success.fullName;
                    sessionStorage['userId'] = success._id;

                    Sammy(function () {
                        this.trigger('redirectUrl', {url: '#/login/'});
                    });
                }).done();
        } else {
            //TODO
        }
    };

    UserController.prototype.logout = function () {
        this.model.logout()
            .then(function () {
                sessionStorage.clear();

                Sammy(function () {
                    this.trigger('redirectUrl', {url: '#/'});
                });
            })
    };

    return {
        load: function (viewBag, model) {
            return new UserController(viewBag, model);
        }
    }
}());

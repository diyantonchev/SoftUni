var app = app || {};

(function (diablo) {
    'use strict';

    function UserController(model, viewBag, notifier) {
        this.model = model;
        this.viewBag = viewBag;
        this.notifier = notifier;
    }

    UserController.prototype.loadLoginForm = function loadLoginForm(container) {
        this.viewBag.showLoginForm(container);
    };

    UserController.prototype.loadRegisterForm = function loadRegisterForm(container) {
        this.viewBag.showRegisterForm(container);
    };

    UserController.prototype.login = function login(userData) {
        var _this = this;
        return this.model.login(userData).then(
            function success(successData) {
                sessionStorage.authtoken = successData._kmd.authtoken;
                sessionStorage.username = successData.username;
                sessionStorage.userId = successData._id;
                _this.notifier.notifySuccess('Successfully logged in');
                Sammy(function () {
                    this.trigger('redirectUrl', { url: '#/' });
                });
            },
            function error() {
                _this.notifier.notifyError('Invalid username or password');
            });
    };

    UserController.prototype.registerUser = function registerUser(userData) {
        if (userData.password !== userData.confirmPassword) {
            this.notifier.notifyError('The passowrds don\'t match');
        } else {
            var _this = this;
            var user = { username: userData.username, password: userData.password };
            this.model.register(user).then(
                function success() {
                    _this.notifier.notifySuccess('Successfully registered user');
                    Sammy(function () {
                        this.trigger('login', user);
                    });
                }, function error() {
                    _this.notifier.notifyError('User already exists');
                }).done();
        }
    };

    UserController.prototype.logout = function logout() {
        var _this = this;
        this.model.logout().then(function () {
            sessionStorage.clear();
            _this.notifier.notifySuccess('Successfully logged out');
            Sammy(function () {
                this.trigger('redirectUrl', { url: '#/' });
            });
        });
    };

    diablo.userController = {
        load: function (model, viewBag, notifier) {
            return new UserController(model, viewBag, notifier);
        }
    };

})(app);
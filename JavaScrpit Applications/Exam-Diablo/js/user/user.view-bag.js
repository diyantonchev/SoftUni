var app = app || {};

(function (diablo) {
    'use strict';

    var notifier = diablo.notifier;

    function showLoginForm(container) {
        $.get('templates/login.html', function (template) {
            $(container).html(template);
            $('#login-button').on('click', function () {
                var username = $('#username').val();
                var password = $('#password').val();
                var userData = { username: username, password: password };
                Sammy(function () {
                    this.trigger('login', userData);
                });
            });
        });
    }

    function showRegisterForm(container) {
        $.get('templates/register.html', function (template) {
            $(container).html(template);
            $('#register-button').on('click', function () {
                var username = $('#username').val();
                var password = $('#password').val();
                var confirmPassword = $('#confirm-password').val();
                var userData = { username: username, password: password, confirmPassword: confirmPassword };
                Sammy(function () {
                    this.trigger('registerUser', userData);
                });
            });
        });
    }

    diablo.userViewBag = {
        showLoginForm: showLoginForm,
        showRegisterForm: showRegisterForm,
    };

})(app);
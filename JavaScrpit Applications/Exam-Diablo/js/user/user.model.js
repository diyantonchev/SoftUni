var app = app || {};

(function (diablo) {
    'use strict';

    function UserModel(requester) {
        this.requester = requester;
        this.setServiceUrl(requester.baseUrl, requester.appId);
    }

    UserModel.prototype.setServiceUrl = function setServiceUrl(baseUrl, appId) {
        this._serviceUrl = baseUrl + '/user/' + appId;
    };

    UserModel.prototype.register = function register(data) {
        var requestUrl = this._serviceUrl;
        return this.requester.post(requestUrl, data, false);
    };

    UserModel.prototype.login = function login(data) {
        var requestUrl = this._serviceUrl + '/login';
        return this.requester.post(requestUrl, data, false);
    };

    UserModel.prototype.logout = function logout() {
        var requestUrl = this._serviceUrl + '/_logout';
        return this.requester.post(requestUrl);
    };

    diablo.userModel = {
        load: function (requester) {
            return new UserModel(requester);
        }
    };

})(app);
var app = app || {};

(function (softUniCalendar) {
    'use strict';

    function Requester(baseUrl, appId, appSecret) {
        this.baseUrl = baseUrl;
        this.appId = appId;
        this._appSecret = appSecret;
    }

    Requester.prototype.makeRequest = function makeRequest(url, method, headers, data) {
        var defer = Q.defer();
        $.ajax({
            method: method,
            url: url,
            data: JSON.stringify(data) || null,
            headers: headers,
            success: function (response) {
                defer.resolve(response);
            },
            error: function (response) {
                defer.reject(response);
            }
        });

        return defer.promise;
    };

    Requester.prototype.getHeaders = function getHeaders(isJSON, useSession) {
        var headers = {};
        if (isJSON) {
            headers['Content-Type'] = 'application/json';
        }

        if (useSession) {
            headers.Authorization = 'Kinvey ' + sessionStorage.authtoken;
        } else {
            var token = this.appId + ':' + this._appSecret;
            headers.Authorization = 'Basic ' + btoa(token);
        }

        return headers;
    };

    Requester.prototype.get = function get(url, useSession) {
        if (useSession === undefined) {
            useSession = true;
        }

        var headers = this.getHeaders(false, useSession);
        return this.makeRequest(url, 'GET', headers, {});
    };

    Requester.prototype.post = function post(url, data, useSession) {
        if (useSession === undefined) {
            useSession = true;
        }

        var headers = this.getHeaders(true, useSession);
        return this.makeRequest(url, 'POST', headers, data);
    };

    Requester.prototype.put = function put(url, data) {
        var headers = this.getHeaders(true, true);
        return this.makeRequest(url, 'PUT', headers, data);
    };

    Requester.prototype.del = function del(url, data) {
        var headers = this.getHeaders(false, true);
        return this.makeRequest(url, 'DELETE', headers, data);
    };

    softUniCalendar.requester = {
        config: function (baseUrl, appId, appSecret) {
            return new Requester(baseUrl, appId, appSecret);
        }
    };

})(app);
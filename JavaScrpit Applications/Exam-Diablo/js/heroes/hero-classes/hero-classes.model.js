var app = app || {};

(function (diablo) {
    'use strict';

     function HeroClassesModel(requester) {
        this.requester = requester;
        this.setServiceUrl(requester.baseUrl, requester.appId);
    }

    HeroClassesModel.prototype.setServiceUrl = function setServiceUrl(baseUrl, appId) {
        this._serviceUrl = baseUrl + '/appdata/' + appId + '/hero-classes/';
    };

    HeroClassesModel.prototype.getAll = function getAll() {
        var requestUrl = this._serviceUrl;
        return this.requester.get(requestUrl);
    };
    
   diablo.heroClassesModel = {
        load: function (requester) {
            return new HeroClassesModel(requester);
        }
    }; 
    
} (app));
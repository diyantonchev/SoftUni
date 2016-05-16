var app = app || {};

(function (diablo) {
    'use strict';

    function HeroesModel(requester) {
        this.requester = requester;
        this.setServiceUrl(requester.baseUrl, requester.appId);
    }

    HeroesModel.prototype.setServiceUrl = function setServiceUrl(baseUrl, appId) {
        this._serviceUrl = baseUrl + '/appdata/' + appId + '/heroes/';
    };

    HeroesModel.prototype.getAll = function getAll() {
        var requestUrl = this._serviceUrl;
        return this.requester.get(requestUrl);
    };

    HeroesModel.prototype.listUsersHeroes = function listUsersHeroes(userId) {
        var requestUrl = this._serviceUrl + '?query={"_acl.creator":"' + userId + '"}' +
            '&resolve=class&retainReferences=false';
        return this.requester.get(requestUrl);
    };

    HeroesModel.prototype.getHero = function getHero(heroId) {
        var requestUrl = this._serviceUrl + heroId +
            '?resolve=class,items,items.type&retainReferences=false';
        return this.requester.get(requestUrl);
    };

    HeroesModel.prototype.addHero = function addHero(hero) {
        var requestUrl = this._serviceUrl;
        return this.requester.post(requestUrl, hero);
    };

    HeroesModel.prototype.editHero = function editHero(heroId, editedHero) {
        var requestUrl = this._serviceUrl + heroId;
        return this.requester.put(requestUrl, editedHero);
    };

    diablo.heroesModel = {
        load: function (requester) {
            return new HeroesModel(requester);
        }
    };

} (app));
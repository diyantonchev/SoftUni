var app = app || {};

(function (diablo) {
    'use strict';

    function ItemsModel(requester) {
        this.requester = requester;
        this.setServiceUrl(requester.baseUrl, requester.appId);
    }

    ItemsModel.prototype.setServiceUrl = function setServiceUrl(baseUrl, appId) {
        this._serviceUrl = baseUrl + '/appdata/' + appId + '/items/';
    };

    // ItemsModel.prototype.getAll = function getAll() {
    //     var requestUrl = this._serviceUrl;
    //     return this.requester.get(requestUrl);
    // };

    ItemsModel.prototype.getItemTypes = function getItemTypes() {
        var requestUrl = requester.baseUrl + '/appadata/' + requester.appId + '/item-types/';
        return this.requester.get(requestUrl);
    };

    ItemsModel.prototype.getStoreItems = function getStoreItems(userId) {
        var requestUrl = this._serviceUrl + '?resolve=type&retainReferences=false';
        return this.requester.get(requestUrl);
    };

    diablo.itemsModel = {
        load: function (requester) {
            return new ItemsModel(requester);
        }
    };

} (app));
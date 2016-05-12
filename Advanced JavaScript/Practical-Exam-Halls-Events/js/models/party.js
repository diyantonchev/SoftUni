var app = app || {};

(function (eventsSystem) {
    'use strict';

    function Party(options) {
        Party._super.call(this, options);
        this.setIsCatered(options.isCatered);
        this.setIsBirthday(options.isBirthday);
        this.setOrganiser(options.organiser);
    }

    Party.extends(eventsSystem.event);

    Party.prototype.setIsCatered = function setIsCatered(value) {
        if (value) {
            this._isCatered = true;
        } else {
            this._isCatered = false;
        }
    };

    Party.prototype.getIsCatered = function getIsCatered() {
        return this._isCatered;
    };

    Party.prototype.setIsBirthday = function setIsBirthday(value) {
        if (value) {
            this._isBirthday = true;
        } else {
            this._isBirthday = false;
        }
    };

    Party.prototype.getIsBirthday = function getIsBirthday() {
        return this._isBirthday;
    };

    Party.prototype.setOrganiser = function setOrganiser(value) {
        if (!(value instanceof eventsSystem.employee)) {
            throw new Error(value + ' is not a employee instance');
        }

        this._organiser = value;
    };

    Party.prototype.getOrganiser = function getOrganiser() {
        return this._organiser;
    };

    eventsSystem.party = Party;

})(app);
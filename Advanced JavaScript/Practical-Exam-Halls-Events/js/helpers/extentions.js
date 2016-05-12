Function.prototype.extends = function (parent) {
    this._super = parent;
    this.prototype = Object.create(parent.prototype);
    this.prototype.constructor = this;
};
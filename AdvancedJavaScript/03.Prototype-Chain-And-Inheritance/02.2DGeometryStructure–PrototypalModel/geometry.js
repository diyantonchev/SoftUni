var ShapeModule = (function () {
    "use strict";
    var Shape = {
        init: function init(color) {
            this._color = color;
        },

        toString: function () {
            return 'Color: ' + this._color;
        }
    };

    var Circle = Object.create(Shape);
    Circle.init = function init(centerX, centerY, radius, color) {
        this._centerX = Number(centerX);
        this._centerY = Number(centerY);
        this._radius = Number(radius);
        Shape.init.call(this, color);
        return this;
    };

    Circle.toString = function () {
        return 'Circle: [' +
            'Center: O(' + this._centerX + ',' + this._centerY + '), ' +
            'Radius: ' + this._radius + ', ' +
            Shape.toString.call(this) + ']';
    };

    var Rectangle = Object.create(Shape);
    Rectangle.init = function init(topLeftX, topLeftY, width, height, color) {
        this._topLeftX = Number(topLeftX);
        this._topLeftY = Number(topLeftY);
        this._width = Number(width);
        this._height = Number(height);
        Shape.init.call(this, color);
        return this;
    };

    Rectangle.toString = function () {
        return 'Rectangle: [' +
            'A(' + this._topLeftX + ', ' + this._topLeftY + '), ' +
            'Width(' + this._width + '), ' +
            'Height(' + this._height + '), ' +
            Shape.toString.call(this) + ']';
    };

    var Triangle = Object.create(Shape);
    Triangle.init = function init(aX, aY, bX, bY, cX, cY, color) {
        this._aX = Number(aX);
        this._aY = Number(aY);
        this._bX = Number(bX);
        this._bY = Number(bY);
        this._cX = Number(cX);
        this._cY = Number(cY);
        Shape.init.call(this, color);
        return this;
    };

    Triangle.toString = function () {
        return 'Triangle: [' +
            'A(' + this._aX + ', ' + this._aY + '), ' +
            'B(' + this._bX + ', ' + this._bY + '), ' +
            'C(' + this._cX + ', ' + this._cY + '), ' +
            Shape.toString.apply(this) + ']';
    };

    var Line = Object.create(Shape);
    Line.init = function init(aX, aY, bX, bY, color) {
        this._aX = Number(aX);
        this._aY = Number(aY);
        this._bX = Number(bX);
        this._bY = Number(bY);
        Shape.init.call(this, color);
        return this;
    };

    Line.toString = function () {
        return 'Line: [' +
            'A(' + this._aX + ', ' + this._aY + '), ' +
            'B(' + this._bX + ', ' + this._bY + '), ' +
            Shape.toString.call(this) + ']';
    };

    var Segment = Object.create(Shape);
    Segment.init = function init(aX, aY, bX, bY, color) {
        this._aX = Number(aX);
        this._aY = Number(aY);
        this._bX = Number(bX);
        this._bY = Number(bY);
        Shape.init.call(this, color);
        return this;
    };

    Segment.toString = function () {
        return 'Segment: [' +
            'A(' + this._aX + ', ' + this._aY + '), ' +
            'B(' + this._bX + ', ' + this._bY + '), ' +
            Shape.toString.call(this) + ']';
    };

    return {
        Circle: Circle,
        Rectangle: Rectangle,
        Triangle: Triangle,
        Line: Line,
        Segment: Segment
    }

}());

var circle = ShapeModule.Circle;
circle.init(5, 7, 10, '#fff');
console.log(circle.toString());
var rectangle = ShapeModule.Rectangle;
rectangle.init(10, 12, 200, 300, '#999999');
console.log(rectangle.toString());
var triangle = ShapeModule.Triangle;
triangle.init(5, 2, 1, 2, 4, 5, '#000');
console.log(triangle.toString());
var line = ShapeModule.Line;
line.init(4, 6, 5, 3, '#AAA');
console.log(line.toString());
var segment = ShapeModule.Segment;
segment.init(7, 3, 4, 5, '#CCC');
console.log(segment.toString());

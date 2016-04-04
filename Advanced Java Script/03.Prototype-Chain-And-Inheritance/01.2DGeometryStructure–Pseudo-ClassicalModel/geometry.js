var ShapeModule = (function () {
    "use strict";

    var Shape = (function () {
        function Shape(color) {
            this.color = color;
        }

        Shape.prototype.toString = function () {
            return 'Color: ' + this.color;
        };

        Shape.prototype.getDistanceBetweenTwoPoints = function (aX, aY, bX, bY) {
            var deltaX, deltaY;
            deltaX = aX - bX;
            deltaY = aY - bY;

            return Math.sqrt(deltaX * deltaX + deltaY * deltaY);
        };

        return Shape;
    }());


    var Circle = (function () {
        function Circle(centerX, centerY, radius, color) {
            this.centerX = Number(centerX);
            this.centerY = Number(centerY);
            this.radius = Number(radius);
            Shape.call(this, color);
        }

        Circle.prototype = Object.create(Shape.prototype);
        Circle.constructor = Circle;

        Circle.prototype.toString = function () {
            return 'Circle: [' +
                'Center: O(' + this.centerX + ',' + this.centerY + '), ' +
                'Radius: ' + this.radius + ', ' +
                Shape.prototype.toString.call(this) + ']';
        };

        return Circle;
    }());

    var Rectangle = (function () {
        function Rectangle(topLeftX, topLeftY, width, height, color) {
            this.topLeftX = Number(topLeftX);
            this.topLeftY = Number(topLeftY);
            this.width = Number(width);
            this.height = Number(height);
            Shape.call(this, color);
        }

        Rectangle.prototype = Object.create(Shape.prototype);
        Rectangle.prototype.constructor = Rectangle;

        Rectangle.prototype.toString = function () {
            return 'Rectangle: [' +
                'A(' + this.topLeftX + ', ' + this.topLeftY + '), ' +
                'Width(' + this.width + '), ' +
                'Height(' + this.height + '), ' +
                Shape.prototype.toString.call(this) + ']';
        };

        return Rectangle;
    }());

    var Triangle = (function () {
        function Triangle(aX, aY, bX, bY, cX, cY, color) {
            setTriangleVertices(this, aX, aY, bX, bY, cX, cY);
            Shape.call(this, color);
        }

        function setTriangleVertices(triangle, aX, aY, bX, bY, cX, cY) {
            if (!triangle.isValidTriangle(aX, aY, bX, bY, cX, cY)) {
                throw new Error('The points provided do not form a valid triangle.');
            } else {
                triangle.aX = aX;
                triangle.aY = aY;
                triangle.bX = bX;
                triangle.bY = bY;
                triangle.cX = cX;
                triangle.cY = cY;
            }
        }

        Triangle.prototype = Object.create(Shape.prototype);
        Triangle.constructor = Triangle;

        Triangle.prototype.isValidTriangle = function (aX, aY, bX, bY, cX, cY) {
            var sideA = Shape.prototype.getDistanceBetweenTwoPoints(aX, aY, bX, bY);
            var sideB = Shape.prototype.getDistanceBetweenTwoPoints(bX, bY, cX, cY);
            var sideC = Shape.prototype.getDistanceBetweenTwoPoints(aX, aY, cX, cY);

            if (sideA <= 0 || sideB <= 0 || sideC <= 0) {
                return false;
            }

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA) {
                return false;
            }

            return true;
        };

        Triangle.prototype.toString = function () {
            return 'Triangle: [' +
                'A(' + this.aX + ', ' + this.aY + '), ' +
                'B(' + this.bX + ', ' + this.bY + '), ' +
                'C(' + this.cX + ', ' + this.cY + '), ' +
                Shape.prototype.toString.call(this) + ']';
        };

        return Triangle;
    }());

    var Line = (function () {
        function Line(aX, aY, bX, bY, color) {
            this.aX = Number(aX);
            this.aY = Number(aY);
            this.bX = Number(bX);
            this.bY = Number(bY);
            Shape.call(this, color);
        }

        Line.prototype = Object.create(Shape.prototype);
        Line.constructor = Line;

        Line.prototype.toString = function () {
            return 'Line: [' +
                'A(' + this.aX + ', ' + this.aY + '), ' +
                'B(' + this.bX + ', ' + this.bY + '), ' +
                Shape.prototype.toString.call(this) + ']';
        };

        return Line;
    }());

    var Segment = (function () {
        function Segment(aX, aY, bX, bY, color) {
            this.aX = Number(aX);
            this.aY = Number(aY);
            this.bX = Number(bX);
            this.bY = Number(bY);
            Shape.call(this, color);
        }

        Segment.prototype = Object.create(Shape.prototype);
        Segment.constructor = Segment;

        Segment.prototype.toString = function () {
            return 'Segment: [' +
                'A(' + this.aX + ', ' + this.aY + '), ' +
                'B(' + this.bX + ', ' + this.bY + '), ' +
                Shape.prototype.toString.call(this) + ']';
        };

        return Segment;
    }());

    return {
        Circle: Circle,
        Rectangle: Rectangle,
        Triangle: Triangle,
        Line: Line,
        Segment: Segment
    };
}());

var circle = new ShapeModule.Circle(5, 7, 10, '#fff');
console.log(circle.toString());
var rectangle = new ShapeModule.Rectangle(10, 12, 200, 300, '#999999');
console.log(rectangle.toString());
var triangle = new ShapeModule.Triangle(5, 2, 1, 2, 4, 5, '#000');
console.log(triangle.toString());
var line = new ShapeModule.Line(4, 6, 5, 3, '#AAA');
console.log(line.toString());
var segment = new ShapeModule.Segment(7, 3, 4, 5, '#CCC');
console.log(segment.toString());
var animal = (function () {
    "use strict";

    var animal = {
        init: function (name, age) {
			//var instance = Object.create(this);
			//instance.name = name;
			//instance.age = age;
			//return instance;
			this.name = name;
			this.age = age;
            return this;
        },
        get name() {
            return this._name;
        },
        set name(value) {
            if (typeof value !== 'string' || value.length < 3) {
                throw new Error('Wrong one');
            }

            this._name = value;
        },
        get age() {
            return this._age;
        },
        set age(value) {
            if (isNaN(value)) {
                throw new Error('chislo be');
            }

            this._age = value;
        },
        toString: function () {
            return this.name + ' ' + this.age;
        }
    };

    return animal;
}());

var dog = (function (parent) {
    "use strict";

    var dog = Object.create(parent);

    Object.defineProperties(dog, {
        init: {
            value: function (name, age, legs) {
                parent.init.call(this, name, age);
                this.legs = legs;
                return this;
            }
        },
        bark: {
            value: function () {
                return 'Barking...';
            }
        },
        toString:{
            value: function(){
               var baseToString = parent.toString.call(this);
                return baseToString + ' ' + this.legs;
            }
        }
    });

    return dog;
}(animal));

var sharo = Object.create(dog).init('sharo',10, 5);

console.log(sharo);
console.log(sharo.bark());

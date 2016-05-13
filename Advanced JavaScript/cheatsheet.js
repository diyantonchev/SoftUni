
Function.prototype.extends = function (parent) {
    this._super = parent;
    this.prototype = Object.create(parent.prototype);
    this.prototype.constructor = this;
};

function inherits(ctor, superCtor) {
    ctor._super = superCtor;
    ctor.prototype = Object.create(superCtor.prototype, {
        constructor: {
            value: ctor,
            enumerable: false,
            writable: false,
            configurable: false
        }
    });
}

var Person = (function () {
    function Person(name, age) {
        this.name = name;
        this.age = age;
    }

    Person.prototype.saySomething = function () {
        return this.name + ' ' + this.age;
    };

    return Person;
} ());


var Musician = (function () {

    function Musician(name, age, instrument) {
        Musician._super.call(this, name, age);
        this.instrument = instrument;
    }

    Musician.extends(Person);
    // inherits(Musician, Person);

    Musician.prototype.play = function () {
       console.log("Playing...");
    };

    return Musician;
} ());

// var phill = new Musician('Phill', 54, 'singer');
// console.log(phill);
// console.log(phill.saySomething());

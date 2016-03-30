function Person(firstName, lastName) {
    "use strict";
    this.firstName = firstName;
    this.lastName = lastName;

    Object.defineProperty(this, 'fullName', {
        get: function () {
            return this.firstName + " " + this.lastName;
        },

        set: function (name) {
            var names = name.split(/\s+/);
            this.firstName = names[0];
            this.lastName = names[1];
        }
    });
}

var person = new Person("Peter", "Jackson");

// Getting values
console.log(person.firstName);
console.log(person.lastName);
console.log(person.fullName);
console.log();

// Changing values
person.firstName = "Michael";
console.log(person.firstName);
console.log(person.fullName);
console.log();
person.lastName = "Williams";
console.log(person.lastName);
console.log(person.fullName);
console.log();

// Changing the full name should work too
person.fullName = "Alan Marcus";
console.log(person.fullName);
console.log(person.firstName);
console.log(person.lastName);

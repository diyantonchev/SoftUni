function Person(firstName, lastName, age) {
    if (!(this instanceof Person)) {
        return new Person(firstName, lastName, age);
    }

    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
    this.toString = function () {
        return this.firstName + ' ' + this.lastName + '(' + this.age + ')';
    }
}

function groupBy(persons, criteria) {
    var groups = {};

    for (var key in persons) {
        var person = persons[key];

        if (criteria.toLowerCase() === 'age') {
            if (groups[person.age] == undefined) {
                groups[person.age] = [];
            }

            groups[person.age].push(person.toString());

        } else if (criteria.toLowerCase() === 'firstname') {
            if (groups[person.firstName] === undefined) {
                groups[person.firstName] = [];
            }

            groups[person.firstName].push(person.toString());

        } else if (criteria.toLowerCase() == 'lastname') {
            if (groups[person.lastName] === undefined) {
                groups[person.lastName] = [];
            }

            groups[person.lastName].push(person.toString());
        }
    }

    return groups;
}

function printGroup(group) {
    for (var key in group) {
        console.log('Group %s : [%s]', key, group[key].join(','));
    }
}

var people = [
    new Person("Scott", "Guthrie", 38),
    new Person("Scott", "Johns", 36),
    new Person("Scott", "Hanselman", 39),
    new Person("Jesse", "Liberty", 57),
    new Person("Jon", "Skeet", 38)
];

var groupedByFirstName = groupBy(people, 'firstName');
printGroup(groupedByFirstName);
console.log();
var groupedByLastName = groupBy(people, 'lastName');
printGroup(groupedByLastName);
console.log();
var groupedByAge = groupBy(people, 'age');
printGroup(groupedByAge);
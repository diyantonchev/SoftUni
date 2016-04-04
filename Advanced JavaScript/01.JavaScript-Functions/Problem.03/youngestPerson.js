function findYoungestPerson(array) {
    var result = array.sort(function (x, y) {
        return x.age - y.age;
    }).filter(function (el) {
        return el.hasSmartphone === true;
    });

    return result[0].firstname + ' ' + result[0].lastname;
}

var people = [
    {firstname: 'George', lastname: 'Kolev', age: 32, hasSmartphone: false},
    {firstname: 'Vasil', lastname: 'Kovachev', age: 40, hasSmartphone: true},
    {firstname: 'Bay', lastname: 'Ivan', age: 81, hasSmartphone: true},
    {firstname: 'Baba', lastname: 'Ginka', age: 40, hasSmartphone: false}];

var youngestPerson = findYoungestPerson(people);
console.log("The youngest person is %s", youngestPerson);
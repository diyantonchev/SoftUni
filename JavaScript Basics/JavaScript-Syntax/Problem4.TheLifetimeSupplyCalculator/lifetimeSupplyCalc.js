function calcSupply(name, age, maxAge, food, foodPerDay) {
    var days = (maxAge - age) * 365;
    var amount = days * foodPerDay;
    console.log('%dkg of %s would be enough until %s %s %d years old.',
        amount, food, name,name === 'I'? 'am': 'is' ,maxAge);
}

var me = {name: 'I', age: 38, maxAge: 118, food: 'chocolate', foodPerDay: 0.5};
var pesho = {name: 'Pesho', age: 20, maxAge: 87, food: 'fruits', foodPerDay: 2};
var gosho = {name: 'Gosho', age: 16, maxAge: 102, food: 'nuts', foodPerDay: 1.1};

var persons = [me, pesho, gosho];

for (var i in persons) {
    calcSupply(persons[i].name, persons[i].age, persons[i].maxAge, persons[i].food, persons[i].foodPerDay);
}
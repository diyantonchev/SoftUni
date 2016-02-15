var SortedList = (function () {

    var list = [];

    function SortedList() {
        "use strict";
        this.length = 0;

        this.toString = function () {
            return list;
        };
    }

    SortedList.prototype.add = function add(number) {
        list.push(number);

        list.sort(function (x, y) {
            return x - y;
        });

        this.length += 1;
    };

    SortedList.prototype.get = function get(index) {
        return list[index];
    };

    return SortedList;
}());

var list = new SortedList;
list.add(11);
list.add(67);
list.add(10);
list.add(33);
list.add(0.1);
list.add(2);
list.add(0.01);
list.add(49);
console.log(list.toString());
console.log(list.length);
console.log(list.get(6));
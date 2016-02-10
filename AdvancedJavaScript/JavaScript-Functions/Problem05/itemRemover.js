Array.prototype.removeItem = function (elementToRemove) {
    this.forEach(function (element, index, arr) {
        if (element === elementToRemove) {
            arr.splice(index, 1);
        }
    });
};

var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];
arr.removeItem(1);
console.log(arr);

var arr1 = ['hi', 'bye', 'hello'];
arr1.removeItem('bye');
console.log(arr1);

var arr2 = [true, false, false, true];
arr2.removeItem(true);
console.log(arr2);

var chochko = {name: 'Chochko', age: 14};
var djego = {name: 'Djego', age: 22};
var arr3 = [chochko, djego];
arr3.removeItem(djego);
console.log(arr3);


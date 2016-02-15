Array.prototype.flatten = function () {
    "use strict";

    var flattenArray = [];
    function getValues(array) {
        array.forEach(function(element){
           if(element.constructor !== Array) {
               flattenArray.push(element)
           } else {
               getValues(element);
           }
        });
    }

    getValues(this);
    return flattenArray;
};

var array = [1, 2, 3, 4];
console.log(array.flatten());

array = [1, 2, [3, 4], [5, 6]];
console.log(array.flatten());
console.log(array); // Not changed

array = [0, ["string", "values"], 5.5, [[1, 2, true], [3, 4, false]], 10];
console.log(array.flatten());

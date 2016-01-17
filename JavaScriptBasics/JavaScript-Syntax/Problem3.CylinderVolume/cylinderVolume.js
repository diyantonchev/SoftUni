function calcCylinderVol(arr) {
    var radius = arr[0];
    var height = arr[1];
    var volume = Math.PI * radius * radius * height;
    return volume;
}

var parameters1 = [2, 4];
var volume1 = calcCylinderVol(parameters1);
console.log(Number(volume1).toFixed(3));

var parameters2 = [5, 8];
var volume2 = calcCylinderVol(parameters2);
console.log(Number(volume2).toFixed(3));

var parameters3 = [12, 3];
var volume3 = calcCylinderVol(parameters3);
console.log(Number(volume3).toFixed(3));
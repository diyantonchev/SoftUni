function calculateCircleArea(r) {
 var circleArea = Math.PI * r * r;
 return circleArea;
}

document.getElementById("first").innerHTML = calculateCircleArea(7);
document.getElementById("second").innerHTML = calculateCircleArea(1.5);
document.getElementById("third").innerHTML = calculateCircleArea(20);
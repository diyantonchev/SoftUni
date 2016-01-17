function setTime() {
    var time = new Date();

    var hours = time.getHours();
    if (hours < 10) {
        hours = "0" + hours;
    }

    var minutes = time.getMinutes();
    if (minutes < 10) {
        minutes = "0" + minutes;
    }

    var seconds = time.getSeconds();
    if (seconds < 10) {
        seconds = "0" + seconds;
    }

    document.getElementById("timer").innerHTML = hours + " : " + minutes + " : " + seconds;
}
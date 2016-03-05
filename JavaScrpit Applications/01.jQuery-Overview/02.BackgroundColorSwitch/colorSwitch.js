$(document).ready(function () {
    "use strict";

    function switchColor() {
        var animalClass = ('.' + $('#class').val()).toLocaleLowerCase(),
            color = $('#color').val();
        $(animalClass).css('background', color);
    }

    var btn = $('#paint-btn');
    btn.on('click', switchColor);
});


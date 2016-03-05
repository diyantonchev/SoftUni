$(document).ready(function () {
    "use strict";

    function prependDivElement() {
        "use strict";

        var divElement = $('<div>').text('New Element').addClass('dynamicCreatedDiv');
        divElement.prependTo($('.content'));
    }

    function appendLiElement() {
        var li = $('<li>').text('New Element');
        li.appendTo($('ul'));
    }

    $('#prepend-btn').on('click', prependDivElement);
    $('#append-btn').on('click', appendLiElement);
});
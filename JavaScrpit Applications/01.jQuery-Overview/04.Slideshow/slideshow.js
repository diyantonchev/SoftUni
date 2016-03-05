$(document).ready(function () {
    "use strict";
    var autoPlay;

    function nextSlide() {
        var currentActive = $('.shown');
        var nextActive = currentActive.next();

        if (nextActive.length === 0) {
            nextActive = $('#slide-show').find('img').first();
        }

        currentActive.removeClass('shown').addClass('hidden').css('z-index', -10);
        nextActive.removeClass('hidden').addClass('shown').css('z-index', 10);
    }

    function previousSlide() {
        var currentActive = $('.shown');
        var nextActive = currentActive.prev();

        if (nextActive.length === 0) {
            nextActive = $('#slide-show').find('img').last();
        }

        currentActive.removeClass('shown').addClass('hidden').css('z-index', -10);
        nextActive.removeClass('hidden').addClass('shown').css('z-index', 10);

    }

    autoPlay = function autoPlay() {
        return setInterval(function () {
            nextSlide()
        }, 5000);
    };

    autoPlay();

    $('#right-arrow').on('click', nextSlide);

    $('#left-arrow').on('click', previousSlide);
});
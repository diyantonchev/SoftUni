var app = app || {};

(function (softUniCalendar) {
    'use strict';

    function notifySuccess(msg) {
        noty({
            text: msg,
            theme: 'relax',
            type: 'success',
            layout: 'topCenter',
            timeout: 2000
        });
    }

    function notifyError(msg) {
        noty({
            text: msg,
            theme: 'relax',
            type: 'error',
            layout: 'topCenter',
            timeout: 5000
        });
    }

    softUniCalendar.notifier = {
        notifySuccess: notifySuccess,
        notifyError: notifyError
    };

})(app);
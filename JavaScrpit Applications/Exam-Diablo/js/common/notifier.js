var app = app || {};

(function (diablo) {
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

    function confirm(msg) {
        var answer = Q.defer();

        noty({
            text: msg,
            type: 'confirm',
            buttons: [
                {
                    addClass: 'btn btn-primary', text: 'Ok', onClick: function ($noty) {
                        answer.resolve(true);
                        $noty.close();
                    }
                },
                {
                    addClass: 'btn btn-danger', text: 'Cancel', onClick: function ($noty) {
                        answer.resolve(false);
                        $noty.close();
                    }
                }
            ]
        });

        return answer.promise;
    }

    diablo.notifier = {
        notifySuccess: notifySuccess,
        notifyError: notifyError,
        confirm: confirm
    };

})(app);
var app = app || {};

(function (schoolSystem) {
    function Principal(name) {
        Principal._super.call(this, name);
    }

    Principal.extends(schoolSystem.Human);

    schoolSystem.Principal = Principal;
} (app));
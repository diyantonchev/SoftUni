var app = app || {};

(function (schoolSystem) {
    function Subject() {

    }

    Subject.getSubjects = function getSubjects() {
        return {
            MATH: "MATH",
            ENGLISH: "ENGLISH",
            RUSSIAN: "RUSSIAN",
            CHEMISTRY: "CHEMISTRY",
            BIOLOGY: "BIOLOGY",
            PHILOSOPHY: "PHILOSOPHY",
            HISTORY: "HISTORY",
            GEOGRAPHY: "GEOGRAPHY"
        };
    };

    Subject.isValidSubject = function isValidSubject(subject) {
        var isValid = false;
        var subjects = Object.keys(this.getSubjects());
        $.each(subjects, function (index, el) {
            if (el.toLowerCase() === subject.toLowerCase()) {
                isValid = true;
                return false;
            }
        });
        return isValid;
    };

    schoolSystem.Subject = Subject;
}(app));
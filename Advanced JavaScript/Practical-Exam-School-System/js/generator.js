var app = app || {};

(function(schoolSystem) {
    var availableSubjects = schoolSystem.Subject.getSubjects();

    var semester1 = new schoolSystem.Semester("Semester One");
    var semester2 = new schoolSystem.Semester("Semester Two");
    var semesters = [semester1, semester2];

    var principal = new schoolSystem.Principal("Daniela Borisova");
    var classTeacher = new schoolSystem.Teacher("Teodora Nikolova", null);
    var geographyTeacher = new schoolSystem.Teacher("Ivelin Kirilov", availableSubjects.GEOGRAPHY);

    var goshko = new schoolSystem.Student("Goshko Goshkov");

    classTeacher.addGradeToStudent(goshko, {mark: 5, subject: availableSubjects.MATH, semester: semester1});
    classTeacher.addGradeToStudent(goshko, {mark: 6, subject: availableSubjects.MATH, semester: semester1});
    classTeacher.addGradeToStudent(goshko, {mark: 6, subject: availableSubjects.MATH, semester: semester1});
    classTeacher.addGradeToStudent(goshko, {mark: 3, subject: availableSubjects.MATH, semester: semester2});
    classTeacher.addGradeToStudent(goshko, {mark: 4, subject: availableSubjects.MATH, semester: semester2});

    classTeacher.addGradeToStudent(goshko, {mark: 2, subject: availableSubjects.ENGLISH, semester: semester1});
    classTeacher.addGradeToStudent(goshko, {mark: 2, subject: availableSubjects.ENGLISH, semester: semester1});
    classTeacher.addGradeToStudent(goshko, {mark: 3, subject: availableSubjects.ENGLISH, semester: semester2});
    classTeacher.addGradeToStudent(goshko, {mark: 5, subject: availableSubjects.ENGLISH, semester: semester2});
    classTeacher.addGradeToStudent(goshko, {mark: 5, subject: availableSubjects.ENGLISH, semester: semester2});

    classTeacher.addGradeToStudent(goshko, {mark: 2, subject: availableSubjects.PHILOSOPHY, semester: semester1});
    classTeacher.addGradeToStudent(goshko, {mark: 3, subject: availableSubjects.PHILOSOPHY, semester: semester1});
    classTeacher.addGradeToStudent(goshko, {mark: 4, subject: availableSubjects.PHILOSOPHY, semester: semester1});
    classTeacher.addGradeToStudent(goshko, {mark: 5, subject: availableSubjects.PHILOSOPHY, semester: semester1});
    classTeacher.addGradeToStudent(goshko, {mark: 6, subject: availableSubjects.PHILOSOPHY, semester: semester2});

    geographyTeacher.addGradeToStudent(goshko, {mark: 3, semester: semester1});
    geographyTeacher.addGradeToStudent(goshko, {mark: 3, semester: semester1});
    geographyTeacher.addGradeToStudent(goshko, {mark: 4, semester: semester2});
    geographyTeacher.addGradeToStudent(goshko, {mark: 5, semester: semester2});

    var martina = new schoolSystem.Student("Martina Ivanova");

    classTeacher.addGradeToStudent(martina, {mark: 6, subject: availableSubjects.CHEMISTRY, semester: semester1});
    classTeacher.addGradeToStudent(martina, {mark: 4, subject: availableSubjects.CHEMISTRY, semester: semester1});
    classTeacher.addGradeToStudent(martina, {mark: 5, subject: availableSubjects.CHEMISTRY, semester: semester1});
    classTeacher.addGradeToStudent(martina, {mark: 2, subject: availableSubjects.CHEMISTRY, semester: semester2});
    classTeacher.addGradeToStudent(martina, {mark: 4, subject: availableSubjects.CHEMISTRY, semester: semester2});
    classTeacher.addGradeToStudent(martina, {mark: 6, subject: availableSubjects.CHEMISTRY, semester: semester2});
    classTeacher.addGradeToStudent(martina, {mark: 2, subject: availableSubjects.CHEMISTRY, semester: semester2});

    classTeacher.addGradeToStudent(martina, {mark: 3, subject: availableSubjects.RUSSIAN, semester: semester1});
    classTeacher.addGradeToStudent(martina, {mark: 5, subject: availableSubjects.RUSSIAN, semester: semester1});
    classTeacher.addGradeToStudent(martina, {mark: 6, subject: availableSubjects.RUSSIAN, semester: semester1});
    classTeacher.addGradeToStudent(martina, {mark: 2, subject: availableSubjects.RUSSIAN, semester: semester2});
    classTeacher.addGradeToStudent(martina, {mark: 4, subject: availableSubjects.RUSSIAN, semester: semester2});

    classTeacher.addGradeToStudent(martina, {mark: 4, subject: availableSubjects.HISTORY, semester: semester1});
    classTeacher.addGradeToStudent(martina, {mark: 4, subject: availableSubjects.HISTORY, semester: semester1});
    classTeacher.addGradeToStudent(martina, {mark: 4, subject: availableSubjects.HISTORY, semester: semester2});
    classTeacher.addGradeToStudent(martina, {mark: 2, subject: availableSubjects.HISTORY, semester: semester2});
    classTeacher.addGradeToStudent(martina, {mark: 3, subject: availableSubjects.HISTORY, semester: semester2});

    classTeacher.addGradeToStudent(martina, {mark: 5, subject: availableSubjects.MATH, semester: semester1});
    classTeacher.addGradeToStudent(martina, {mark: 6, subject: availableSubjects.MATH, semester: semester1});
    classTeacher.addGradeToStudent(martina, {mark: 6, subject: availableSubjects.MATH, semester: semester1});
    classTeacher.addGradeToStudent(martina, {mark: 5, subject: availableSubjects.MATH, semester: semester2});
    classTeacher.addGradeToStudent(martina, {mark: 4, subject: availableSubjects.MATH, semester: semester2});

    geographyTeacher.addGradeToStudent(martina, {mark: 5, semester: semester1});
    geographyTeacher.addGradeToStudent(martina, {mark: 5, semester: semester1});
    geographyTeacher.addGradeToStudent(martina, {mark: 4, semester: semester2});
    geographyTeacher.addGradeToStudent(martina, {mark: 4, semester: semester2});

    schoolSystem.students = [goshko, martina];
}(app));
var app = app || {};

(function (schoolSystem) {
    function GradeService() {

    }

    GradeService.prototype.getGrades = function getGrades(student) {
        var studentGrades = student.getGrades();

        var subjects = getGradesBySubjects();
        var subjectsWithAllGrades = [];
        for (var subject in subjects) {
            subjectsWithAllGrades.push(fillFinalGrades(subject, subjects[subject]));
        }

        return subjectsWithAllGrades;

        function getGradesBySubjects() {
            var subjects = [];
            studentGrades.forEach(function (grade) {
                var gradeSubject = grade.getSubject();
                if (subjects[gradeSubject] == null) {
                    subjects[gradeSubject] = [grade];
                } else {
                    subjects[gradeSubject].push(grade);
                }
            });
            return subjects;
        }

        function fillFinalGrades(subject, grades) {
            var subjectWithAllGrades = {};
            subjectWithAllGrades.Subject = subject;
            var semesters = [];
            grades.forEach(function (grade) {
                var semesterName = grade.getSemester().getName();
                if (semesters[semesterName] == null) {
                    semesters[semesterName] = [grade.getMark()]
                } else {
                    semesters[semesterName].push(grade.getMark());
                }
            });

            subjectWithAllGrades.Semesters = [];
            var semesterFinalGrades = [];
            for(var semester in semesters) {
                var semesterCurrentGrades = semesters[semester];
                var semesterObject = {};
                semesterObject.Name = semester;
                semesterObject.Grades = semesterCurrentGrades;

                var calculatedSemesterGrade = CalculateAverageGrade(semesterCurrentGrades);
                semesterObject.SemesterGrade = calculatedSemesterGrade;
                semesterFinalGrades.push(calculatedSemesterGrade);

                subjectWithAllGrades.Semesters.push(semesterObject);
            }

            subjectWithAllGrades.YearGrade = CalculateAverageGrade(semesterFinalGrades);
            return subjectWithAllGrades;
        }

        function CalculateAverageGrade(grades) {
            var total=0;
            for(var i in grades) { total += Number(grades[i]); }
            var average = total / grades.length;

            return average.toFixed(2);
        }
    };

    schoolSystem.GradeService = GradeService;
}(app));
function solve(args) {
    'use strict';

    function Student(student, level) {
        this.id = student.id;
        this.firstname = student.firstname;
        this.lastname = student.lastname;
        if (level) {
            this.averageGrade = getAverageGrade();
        } else {
            this.averageGrade = student.averageGrade;
        }

        this.certificate = student.certificate;
        if (level) {
            this.level = student.level;
        }

        function getAverageGrade() {
            var average = 0;
            student.grades.forEach(function (grade) {
                average += Number(grade);
            });

            average /= student.grades.length;
            return average.toFixed(2);
        }
    }

    function Trainer(trainer) {
        this.id = trainer.id;
        this.firstname = trainer.firstname;
        this.lastname = trainer.lastname;
        this.courses = JSON.parse(JSON.stringify(trainer.courses));
        this.lecturesPerDay = trainer.lecturesPerDay;
    }


    function sortStudentsByLevel() {
        result.students = result.students.sort(function (st1, st2) {
            if (st1.level !== st2.level) {
                return st1.level - st2.level;
            } else {
                return st1.id - st2.id;
            }
        });

    }

    function sortStudentsByName() {
        result.students = result.students.sort(function (st1, st2) {
            if (st1.firstname !== st2.firstname) {
                return st1.firstname.localeCompare(st2.firstname);
            } else {
                return st1.lastname.localeCompare(st2.lastname);
            }
        });
    }

    function sortTrainers() {
        result.trainers = result.trainers.sort(function (tr1, tr2) {
            if (tr1.courses.length !== tr2.courses.length) {
                return tr1.courses.length - tr2.courses.length;
            } else {
                return tr1.lecturesPerDay - tr2.lecturesPerDay;
            }
        });
    }

    var criteria = args.shift(0),
        result = { students: [], trainers: [] };
    args.forEach(function (input) {
        var currentMember = JSON.parse(input);
        if (currentMember.role === 'student') {
            var student = new Student(currentMember, true);
            result.students.push(student);
        } else {
            var trainer = new Trainer(currentMember);
            result.trainers.push(trainer);
        }
    });

    criteria = criteria.split(/\^/);
    var studentCriteria = criteria[0];
    if (studentCriteria === 'level') {
        sortStudentsByLevel();
    } else {
        sortStudentsByName();
    }

    sortTrainers();

    result.students = result.students.map(function (student) {
        return new Student(student, false);
    });

    console.log(JSON.stringify(result));
}

var args = ['level^courses',
    { "id": 0, "firstname": "Angel", "lastname": "Ivanov", "town": "Plovdiv", "role": "student", "grades": ["5.89"], "level": 2, "certificate": false },
    { "id": 1, "firstname": "Mitko", "lastname": "Nakova", "town": "Dimitrovgrad", "role": "trainer", "courses": ["PHP", "Unity Basics"], "lecturesPerDay": 6 },
    { "id": 2, "firstname": "Bobi", "lastname": "Georgiev", "town": "Varna", "role": "student", "grades": ["5.59", "3.50", "4.54", "5.05", "3.45"], "level": 4, "certificate": false },
    { "id": 3, "firstname": "Ivan", "lastname": "Ivanova", "town": "Vidin", "role": "trainer", "courses": ["JS", "Java", "JS OOP", "Database", "OOP", "C#"], "lecturesPerDay": 7 },
    { "id": 4, "firstname": "Mitko", "lastname": "Petrova", "town": "Sofia", "role": "trainer", "courses": ["Database", "JS Apps", "Java"], "lecturesPerDay": 2 },
];

solve(args);
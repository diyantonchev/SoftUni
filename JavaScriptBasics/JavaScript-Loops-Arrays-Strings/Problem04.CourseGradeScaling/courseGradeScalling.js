var json = [{'name': 'Пешо', 'score': 91}, {'name': 'Лилия', 'score': 290}, {
    'name': 'Алекс',
    'score': 343
}, {'name': 'Габриела', 'score': 400}, {'name': 'Жичка', 'score': 70}];

var passedStudents = json.map(function (student) {
    student.score += student.score * 0.10;
    return student;
}).map(function (student) {
    student.score >= 100 ? student.hasPassed = true : student.hasPassed = false;
    return student;
}).filter(function (student) {
    return student.hasPassed == true;
}).sort(function (student1, student2) {
    return student1.name.localeCompare(student2.name);
});

console.log(passedStudents);
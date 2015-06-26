using System;
using System.Collections.Generic;
using System.Linq;

class HumanTest
{
    static void Main()
    {
        var sasho = new Student("Sasho", "Sashev", "123456789s");
        var djordjano = new Student("Djordjano", "Djordjanov", "Kopon1");
        var gamena = new Student("Gamena", "Ruki", "TvaAzliSam");
        var gosho = new Student("Gosho", "Pochivka", "987623");
        var deyan = new Student("Suchki", "Subiram", "723456");
        var krisko = new Student("Drop", "Some", "A54213");
        var mariya = new Student("Pokaji", "Kaksamqtash", "KakGoDvij6");
        var mark = new Student("Mark", "Zuckerberg", "Facebook10");
        var harry = new Student("Harry", "Potter", "a1536hs");
        var mecho = new Student("Mecho", "Puh", "K0Poveche");

        var students = new List<Student>()
        {
           sasho,
           djordjano,
           gamena,
           gosho,
           deyan,
           krisko,
           mariya,
           mark,
           harry,
           mecho
        };

        var orderedStudents = students.OrderByDescending(student => student.FacultyNumber);
        foreach (var student in orderedStudents)
        {
            Console.WriteLine("{0} {1}: {2} ", student.FirstName, student.LastName, student.FacultyNumber);
        }
        Console.WriteLine();

        var shefa = new Worker("Shefa", "NeRaboti",1000, 1);
        var bachkam = new Worker("Bachkam", "Zdravo", 275, 14);
        var money = new Worker("PariNema","Dejstvajte", 50, 10);
        var paulo = new Worker("Paulo", "Coelho", 2000, 12);
        var horhe = new Worker("Jorge", "Bukay", 1500, 12);
        var svetlin = new Worker("Svetlin", "Nakov", 20000, 16);
        var boiko = new Worker("Boyko", "Borisov", 30000, 4);
        var delqn = new Worker("Delyan", "Peevski", 25000, 4);
        var mozzi = new Worker("Kosmin", "Mozzi", 1000, 10);
        var aleksi = new Worker("Aleksi", "Sokachev", 500, 8);

        var workers = new List<Worker>
        {
            shefa,
            bachkam,
            money,
            paulo,
            horhe,
            svetlin,
            boiko,
            delqn,
            mozzi,
            aleksi
        };

        var orderedWorkers = workers.OrderByDescending(worker => worker.MoneyPerHour());
        foreach (var worker in orderedWorkers)
        {
            Console.WriteLine("{0} {1} : {2:C2} per hour", worker.FirstName, worker.LastName, worker.MoneyPerHour());
        }
        Console.WriteLine();

        var humans = new List<Human>()
        {
            sasho, djordjano, gamena, gosho, deyan, krisko, mariya, mark, harry, mecho,
            shefa, bachkam, money, paulo, horhe, svetlin, boiko, delqn, mozzi,aleksi
        };

        var orderedHumansByFirstName = humans.OrderBy(human => human.FirstName);
        foreach (var human in orderedHumansByFirstName)
        {
            Console.WriteLine("{0} {1}", human.FirstName, human.LastName);
        }
        Console.WriteLine();

        var orderedHumansByLastName = humans.OrderBy(human => human.LastName);
        foreach (var human in orderedHumansByLastName)
        {
            Console.WriteLine("{0} {1}", human.FirstName, human.LastName);
        }

    }
}

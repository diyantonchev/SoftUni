using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniLearningSystem
{
    class SULSTest
    {
        static void Main()
        {
            var nasko = new Trainer("Atanas", "Rusenov", 21);
            var fill = new JuniorTrainer("Filip", "Kolev", 28);
            var nakov = new SeniorTrainer("Svetlin", "Nakov", 60);

            var mark = new GraduateStudent("Марк", "Зукърбъргов", 38, 120511, 6.00);
            var mitio = new DropoutStudent("Митьо", "Крика", 40, 343535, 2.30, "Много големи ръки");
            var djordjano = new CurrentStudent("Djordjano", "Djordjankata", 25, 0888155,"Introducing to singing");
            var baiVulcho = new OnlineStudent("Бай", "Вълчо", 73, 4444, 5.60,"OOP");
            var lelqVanche = new OnsiteStudent("Леля", "Ванче", 57, 12034, 4.89, "Аdvanced C#", 20);

            nakov.DeleteCourse("PHP");
            fill.CreateCourse("Advanced C#");
            nasko.CreateCourse("Kopane");
            nakov.DeleteCourse("Kopane"); // Nasko, what are you doing?!?
            Console.WriteLine();

            var persons = new List<Person>()
            {
                nasko,
                fill,
                nakov,
                mark,
                mitio,
                djordjano,
                baiVulcho,
                lelqVanche
            };

            var currentStudents = persons.Where(student => student is CurrentStudent)
                .OrderBy(student => ((Student)student).AverageGrade)
                .Select(student => student);

            foreach (var currentStudent in currentStudents)
            {
                Console.WriteLine(currentStudent);
            }
        }
    }
}

using System;
using System.Collections.Generic;

class Test
{
    static void Main()
    {
        var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

        var odd = numbers.WhereNot(x => x % 2 == 0);
        Console.WriteLine(string.Join(" ", odd));

        var numbersBiggerThanTen = numbers.WhereNot(LessThanTen);
        Console.WriteLine(string.Join(" ", numbersBiggerThanTen));
        Console.WriteLine();

        var students = new List<Student>()
        {
            new Student("Stavri",5.5),
            new Student("Loshiq",2),
            new Student("Me4a", 3.50),
            new Student("Anatoli", 4.4),
            new Student("Rambo", 5.95)
        };

        Console.WriteLine(students.Max(student => student.Grade));
        Console.WriteLine(students.Min(Grade));

        Console.WriteLine();
        Console.WriteLine(students.Max(Name));
        Console.WriteLine(students.Min(student => student.Name));
    }

    static bool LessThanTen(int number)
    {
        if (number <= 10)
        {
            return true;
        }
        return false;
    }

    static double Grade(Student student)
    {
        return student.Grade;
    }

    static string Name(Student student)
    {
        return student.Name;
    }
}